import os
import uuid
import numpy as np
from flask import request
from datetime import datetime
from app.responses.my_response import MyResponse
from app.services.create_embeddings_service import create_text_embeddings
from app.utils.util import is_allowed_file, get_df_bot_content, get_vectordb_bot, create_new_bot_conversation, get_all_bots
from settings import API_LOGGER as logger, CHATBOT as chatbot, SUPPORTED_EXTENSIONS, UPLOAD_FOLDER, ENV
from flask import Blueprint

blueprint_v1 = Blueprint(
    'LocalChatbot_blueprint_v1',
    __name__,
    url_prefix='/v1'
)

# Init cache for bot
cache_bot = {}
logger.info(f'Chatbot: {chatbot}')


@blueprint_v1.route('/conversation', methods=['POST'])
def convert_pdf_to_images_func():
    try:
        logger.info(f'Request: {request}')
        user_question = request.json.get('user_question')
        bot_id = request.json.get('bot_id')
        bot_home_df, _ = get_all_bots()
        all_existing_bot = bot_home_df['bot_id'].values.tolist()
        if bot_id is None:
            return MyResponse(message="No bot id is found", status_code=400,  data=None).get_response()

        if bot_id not in all_existing_bot:
            return MyResponse(message=f"Bot with id {bot_id} not found", status_code=400,  data=None).get_response()

        # load bot to answer the question
        cache_bot_ids = list(cache_bot.keys())
        if bot_id not in cache_bot_ids:
            bot = create_new_bot_conversation(bot_id=bot_id)
            cache_bot[bot_id] = bot
        else:
            bot = cache_bot.get(bot_id)
            bot['activate'] = True

        # create prompt
        prompt = bot["bot"].create_prompt(user_question=user_question)
        if ENV == 'DEV': logger.info(f'prompt: {prompt}')
        answer = chatbot.answer(prompt)
        bot['last_used'] = datetime.now().timestamp()
        response = MyResponse(status_code=200, data=answer, message='')
    except Exception as e:
        logger.exception(e)
        response = MyResponse(status_code=500, data=None, message=f'{e}')
    return response.get_response()



@blueprint_v1.route('/create-bot', methods=['POST'])
def create_bot():
    # get files from request
    files = request.files.getlist('files')
    if not files or len(files) == 0:
        response = MyResponse(message="No files selected", status_code=400, data=None)
        return response.get_response()

    # get bot id
    update_bot = True
    bot_id = request.form.get('bot_id')
    if bot_id is None:
        bot_id = uuid.uuid4()
        update_bot = False
        logger.info(f'Create new bot, bot id: {bot_id}')
    else:
        logger.info(f'Update bot, bot id: {bot_id}')


    # get bot name
    bot_name = request.form.get('bot_name')
    if (bot_name is None) and (not update_bot):
        bot_name = f"Bot_{bot_id}"
        logger.info(f'Set default bot name: {bot_name}')

    uploaded_files = []
    errors = []
    bot_home_df, bot_home_path = get_all_bots()

    for file in files:
        logger.info(f'process file: {file.filename}')
        if (file.filename == '') or (not is_allowed_file(file.filename, SUPPORTED_EXTENSIONS)):
            errors.append({"filename": file.filename, "error": "File is not correct"})
            continue

        # save file to process
        file_path = os.path.join(UPLOAD_FOLDER, file.filename)
        file.save(file_path)
        uploaded_files.append(file_path)

    logger.info(f'creating embedding for files...')
    # get bot df content
    bot_df, bot_df_path = get_df_bot_content(bot_id)

    # get bot vecdb
    bot_vecdb, bot_vecdb_path = get_vectordb_bot(bot_id)
    bot_vecdb = list(bot_vecdb)

    # create embeddings for files and save to bot df and vector db
    doc_embeddings = create_text_embeddings(list_files=uploaded_files)

    logger.info(f'storage for bot vector data and text content')
    for embedding in doc_embeddings:
        new_df_data = {"source": embedding["source"], "content": embedding["content"]}
        bot_df.loc[len(bot_df)] = new_df_data
        bot_vecdb.append(embedding['embedding'])

    bot_df.to_csv(bot_df_path, index=False)
    bot_vecdb = np.array(bot_vecdb).astype('float32')
    np.save(bot_vecdb_path, bot_vecdb)

    if (not update_bot):
        bot_info = {
            'bot_name': bot_name,
            'bot_id': bot_id,
            'df_contents': bot_df_path,
            'vector_db': bot_vecdb_path
        }
        bot_home_df.loc[len(bot_home_df)] = bot_info
        bot_home_df.to_csv(bot_home_path, index=False)

    # update for bot conversation if existing conversation
    cache_bot_ids = list(cache_bot.keys())
    if bot_id in cache_bot_ids:
        del cache_bot[bot_id]
        bot = create_new_bot_conversation(bot_id=bot_id)
        cache_bot[bot_id] = bot

    logger.info(f'finished creating bot')
    data_response = ""
    response = MyResponse(message="created BOT", status_code=200, data=data_response)
    return response.get_response()



@blueprint_v1.route('/get-all-bots', methods=['GET'])
def get_all_created_bots():
    bot_home_df, bot_home_path = get_all_bots()
    all_data = list(bot_home_df[['bot_id', 'bot_name']].values.tolist())
    response = MyResponse(status_code=200, data=all_data, message=f'')
    return response.get_response()


@blueprint_v1.route('/self-kill', methods=['GET'])
def self_kill():
    os._exit(0)


@blueprint_v1.route('/health-check', methods=['GET'])
def health_check():
    response = MyResponse(status_code=200, data='', message=f'API is running...')
    return response.get_response()
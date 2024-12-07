import os
import threading
import pandas as pd
import numpy as np
from nomic import embed
from datetime import datetime
from settings import MEDIA_DIR,MEDIA_DIR_BOT
from app.models.bot.bot import Bot


def get_embedding(text_content):
    '''
    Get embedding for given text list
    Return list of embeddings
    '''
    embeddings = embed.text(text_content, inference_mode="local")['embeddings']
    return embeddings


def convert_table_to_text(table):
    """
    Converte table to text
    """
    rows = []
    for row in table:
        rows.append("\t".join(cell.strip() if cell else "" for cell in row))
    return "\n".join(rows)


def is_allowed_file(filename: str, supported: list):
    """
    File is valid file or nor
    """
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in supported


def get_df_bot_content(bot_id):
    """
    Fetch bot content from bot id
    """
    bot_df_path = os.path.join(MEDIA_DIR_BOT, f'{bot_id}.csv')
    if os.path.exists(bot_df_path):
        bot_df = pd.read_csv(bot_df_path)
    else:
        bot_df = pd.DataFrame(columns=['source', 'content'])
    return bot_df, bot_df_path


def get_vectordb_bot(bot_id):
    """
    Fetch bot content from bot id
    """
    bot_vecdb_path = os.path.join(MEDIA_DIR_BOT, f'{bot_id}.npy')
    if os.path.exists(bot_vecdb_path):
        bot_vecdb = np.load(bot_vecdb_path)
    else:
        bot_vecdb = []
    return bot_vecdb, bot_vecdb_path


def create_new_bot_conversation(bot_id):
    bot = Bot(bot_id=bot_id,
            vector_db=get_vectordb_bot(bot_id=bot_id)[0],
            bot_df_content=get_df_bot_content(bot_id=bot_id)[0])
    bot_active = {
        'bot': bot,
        'last_used': datetime.now().timestamp(),
        'active': True
    }
    return bot_active


def check_bot_expired(cache_bot, timeout = 3600, time_deactive = 15 * 60):
    """
    Check if bot expired
    """
    for bot_id in list(cache_bot.keys()):
        bot = cache_bot.get(bot_id)
        spnt_time_used = (datetime.now().timestamp() - bot['last_used'])
        if (spnt_time_used > timeout) and (not bot['active']):
            del cache_bot[bot_id]
        elif (spnt_time_used > time_deactive) and (bot['active']):
            bot['active'] = False


def check_bot_expired_process(cache_bot):
    import time
    while True:
        time.sleep(5 * 60) # run every 5 minutes
        check_bot_expired(cache_bot=cache_bot)


def start_check_bot_expired():
    thread = threading.Thread(target=check_bot_expired_process)
    thread.daemon = True
    thread.start()


def get_all_bots():
    bot_home_path = os.path.join(MEDIA_DIR_BOT, 'home.csv')
    if os.path.exists(bot_home_path):
        bot_home_df = pd.read_csv(bot_home_path)
    else:
        bot_home_df = pd.DataFrame(columns=['bot_name', 'bot_id', 'df_contents', 'vector_db'])
    return bot_home_df, bot_home_path
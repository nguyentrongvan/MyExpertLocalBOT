import os
from dotenv import load_dotenv
from app.utils.logger import get_logger
from app.models.bot.local_chatbot import LocalChatbot

load_dotenv(f'.env')

ENV = os.environ.get('STAGE')

MODELS_MAP = {
    'gpt4all_falcon': 'gpt4all-falcon-q4_0.gguf',
    'llama': 'Meta-Llama-3-8B-Instruct.Q4_0.gguf',
    'qwen2': 'qwen2-1_5b-instruct-q4_0.gguf',
    'ghost-7b': 'ghost-7b-v0.9.1-Q4_0.gguf'
}

### Settingd for logs
LOG_PATH = os.environ.get('LOG_PATH')
API_APP_NAME = os.environ.get('API_APP_NAME')
API_LOGGER = get_logger(log_path=LOG_PATH, filename=API_APP_NAME, module_name=API_APP_NAME)


### Setting for models
MAX_TOKEN = 1024
DEVICE = 'cpu' # 'gpu', 'amd'
MODEL_NAME = os.environ.get('MODEL_NAME')
CHATBOT = LocalChatbot(model_name=MODEL_NAME, max_token=MAX_TOKEN, device=DEVICE)
MAX_EMBEDD_DIM = 1024
DEFAULT_PROMPT = "Using Vietnamese in your conversation. "\
                 "I want you to act as a document that I am having a conversation with. Your name is 'AI Assistant'. You will " \
                 "provide me with answers from the given info. Give answers in concisely. Return the results in markdown. " \
                 "Refuse to answer any question that the context does not provide an answer for. " \
                 "Get the SOURCE from the CONTEXT. Do Not Fabricate the SOURCE. Make sure to cite results using [[SOURCE](URL)] notation after the context. " \
                 "Do Not Fabricate the SOURCE. Make sure to keep the SOURCE exactly as mentioned in the CONTEXT. Never break character."

### Settings for API
host = os.environ.get('HOST')
port = os.environ.get('PORT')
UPLOAD_FOLDER = 'data/uploads'
SUPPORTED_EXTENSIONS = ['pdf', 'docx', 'doc']
os.makedirs(UPLOAD_FOLDER, exist_ok=True)

### Storage media data
MEDIA_DIR = 'data/media/'
MEDIA_DIR_BOT = os.path.join(MEDIA_DIR, 'bot')
os.makedirs(MEDIA_DIR, exist_ok=True)
os.makedirs(MEDIA_DIR_BOT, exist_ok=True)
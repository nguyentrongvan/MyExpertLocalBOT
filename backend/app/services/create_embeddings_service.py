from tqdm import tqdm
from app.utils.util import get_embedding
from app.services.get_text_service import get_text_from_document

def create_text_embeddings(list_files: list):
    '''
    create_text_embeddings from a list files
    '''
    all_embeddings = []
    for file_path in tqdm(list_files):
        text_content = get_text_from_document(file_path)
        text_content_embeddings = create_embedding_from_text_content(text_content)
        all_embeddings.extend(text_content_embeddings)
    return all_embeddings


def create_embedding_from_text_content(text_content):
    '''
    create_embedding_from_text_content from a text content
    '''
    embeddings = []
    for cont in text_content:
        text = cont['content']
        embedding = get_embedding([text])[0]
        cont['embedding'] = embedding
        embeddings.append(cont)
    return embeddings
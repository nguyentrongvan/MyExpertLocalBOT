import os
import pdfplumber
from docx import Document
from app.utils.util import convert_table_to_text


def get_text_from_document(file_path: str):
    '''
    Extract text from doc file
    '''
    file_extension = file_path.split('.')[-1].lower()
    if file_extension == 'pdf':
        text_content = get_text_from_pdf(file_path)
    elif file_extension in ['docx', 'doc']:
        text_content = get_text_from_docx(file_path)
    else:
        raise Exception(f'File extension {file_extension} not supported')
    return text_content


def get_text_from_docx(file_path):
    '''
    Extract text from docx file
    '''
    document = Document(file_path)
    result = []

    # get base filename from docx file
    file_name = os.path.basename(file_path)

    for i, paragraph in enumerate(document.paragraphs, start=1):
        # get text content from paragraph
        content = paragraph.text.strip()
        if not content: continue

        is_title = "title" in paragraph.style.name.lower()
        # create source for text content
        source = f'{file_name}|paragraph {i}|{content if is_title else ""}'
        result.append({
            "source": source,
            "content": content if not is_title else "",
        })
    return result



def get_text_from_pdf(file_path):
    '''
    Extract text from pdf file
    '''
    result = []
    file_name = os.path.basename(file_path)

    with pdfplumber.open(file_path) as pdf:
        for page_number, page in enumerate(pdf.pages, start=1):
            # extract text from pdf file
            text = page.extract_text()
            if text:
                paragraphs = text.split("\n")
                for i, paragraph in enumerate(paragraphs, start=1):
                    source = f'{file_name}|page {page_number}|paragraph {i}'
                    result.append({
                        "source": source,
                        "content": paragraph.strip()
                    })

            # extract if exist table
            tables = page.extract_tables()
            for table_index, table in enumerate(tables, start=1):
                source = f'{file_name}|page {page_number}|table {table_index}'
                result.append({
                    "source": source,
                    "content": convert_table_to_text(table)
                })
    return result
from settings import DEFAULT_PROMPT
from nomic import embed
import numpy as np
import faiss

class Bot:
    def __init__(self, bot_id, vector_db, bot_df_content):
        print(vector_db.shape)
        dimension = vector_db.shape[1]
        self.bot_id = bot_id
        self.index = faiss.IndexFlatL2(dimension)
        self.vector_db = vector_db
        self.bot_df_content = bot_df_content
        self.index.add(self.vector_db)


    def get_most_similar_context(self, vector_input, num=5):
        _, indices = self.index.search(vector_input, num)
        similar_contexts = []
        for i in indices[0]:
            if i < 0: continue
            content = self.bot_df_content.loc[i, 'content']
            source = self.bot_df_content.loc[i, 'source']
            context = f"SOURCE: {source}, CONTEXT: {content}"
            similar_contexts.append(context)
        return "\n\n###\n\n".join(similar_contexts)


    def get_embedding(self, text):
        embeddings = embed.text([text], inference_mode="local")['embeddings']
        return np.asarray(embeddings[0]).reshape(1, len(embeddings[0]))


    def create_prompt(self, user_question):
        vector_input = self.get_embedding(user_question)
        context = self.get_most_similar_context(vector_input)
        prompt = f"""
                {DEFAULT_PROMPT}
                Context:{context}
                Q:{user_question}
                A:
            """
        return prompt
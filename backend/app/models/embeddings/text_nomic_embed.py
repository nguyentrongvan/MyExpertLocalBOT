from nomic import embed

class TextNomicEmbedding:
    @staticmethod
    def get_embedding(text_content):
        '''
        Get embedding for given text list
        Return list of embeddings
        '''
        embeddings = embed.text([text_content], inference_mode="local")['embeddings'][0]
        return embeddings
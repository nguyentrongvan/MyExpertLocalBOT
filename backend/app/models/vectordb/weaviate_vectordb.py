from app.models.vectordb.vectordb import VectorDB
from settings import API_LOGGER as log, MAX_EMBEDD_DIM

class WeaviateVectorDB(VectorDB):

    def __init__(self, db_url='http://localhost:8080', schema_name = 'EChatbot'):
        log.info('Initializing weaviate vector database...')
        import weaviate
        from app.utils.util import get_embedding
        self.weaviate = weaviate

        self.db_url = db_url
        self.schema_name = schema_name
        self.client = self.weaviate.Client(db_url)
        log.info(f'Connected vector db - db url: {self.db_url}')

        log.info(f'Setup for vector database')
        self.first_init()
        self.get_embedding = get_embedding
        log.info(f'Finished!')


    def get_vector_embedding(self, df2):
        '''
        Get the embedding vector from df
        '''
        list_vec = [df2[key][:MAX_EMBEDD_DIM] for key in list(df2.keys())]
        return list_vec


    def get_text_contents(self, text_df):
        '''
        Get the text contents from df
        '''
        return text_df['content'].tolist()


    def create_bot_schema(self, schema_name = 'EChatbot'):
        '''
        Create a new schema in Weaviate.
        '''
        vector_schema = {
            "class": schema_name,
            "properties": [
                {
                    "name": "bot_id",
                    "dataType": "text",
                },
                {
                    "name": "content",
                    "dataType": ["text"]
                }
            ]
        }
        classes = self.client.schema.get()
        if not any(cls['class'] == schema_name for cls in classes['classes']):
            self.client.schema.create_class(vector_schema)
        else:
            log.info(f"Schema {schema_name} existed!")


    def first_init(self):
        self.create_bot_schema(self.schema_name)


    def find_bot(self, bot_id: str):
        result = self.client.query.get(self.schema_name, ["botid", "content", "vector"]).with_additional(["id"]).with_where({
                                                                                                            "path": ["botid"],
                                                                                                            "operator": "Equal",
                                                                                                            "valueString": bot_id}).do()
        return result


    def add_or_update_data(self, bot_id, text_df, embedding_df):
        '''
        Add bot content and embeddings to Weaviate database.
        '''
        log.info(f'Adding bot content and embeddings to Weaviate database')
        # existed_bot = self.find_bot(bot_id=bot_id)
        new_content = self.get_text_contents(text_df)
        new_vector = self.get_vector_embedding(embedding_df)

        # if not len(existed_bot['data']['Get'][self.schema_name]):
        log.info(f'Adding bot content and embedding to Weaviate database')
        for i in range(len(new_content)):
            content = new_content[i]
            vector = new_vector[i]
            data = {
                "botid": bot_id,
                "content": content
            }
            self.client.data_object.create(data_object=data, class_name=self.schema_name, vector=vector)
        log.info(f'Finished!')



    def create_context(self, bot_id, question, sim_thresh = 0.5, num_results = 3):
        '''
        Create a context based on the question and the similarity threshold
        '''
        log.info(f'Creating context based on the question and the similarity threshold')
        log.info(f'Question: {question}')
        log.info(f'Bot id: {bot_id}')
        search_vector = self.get_embedding(text=question)
        search_vector = search_vector[:MAX_EMBEDD_DIM]

        result = self.client.query.get(self.schema_name, ["content"]).with_additional(["id"]).with_where({
                                                                                        "path": ["botid"],
                                                                                        "operator": "Equal",
                                                                                        "valueString": bot_id}).with_near_vector({
                                                                                        "vector": search_vector,
                                                                                        "certainty": sim_thresh
                                                                                    }).with_limit(num_results).do()


        chosen_sections = []
        print(result)
        if result['data']['Get'][self.schema_name]:
            for obj in result['data']['Get'][self.schema_name]:
                chosen_sections.append(f"* {obj['content']} *")

        log.info(f'Chosen sections: {chosen_sections}')
        return "\n\n###\n\n".join(chosen_sections)

from light_embed import TextEmbedding

model = TextEmbedding(model_name_or_path='onnx-models/all-MiniLM-L6-v2-onnx')

class LightTextEmbedding:
    @staticmethod
    def get_embedding(text):
        return model.encode([text])[0]
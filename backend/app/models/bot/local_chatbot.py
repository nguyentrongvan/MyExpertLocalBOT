import os

class LocalChatbot:
    def __init__(self, model_path='gpt4all_falcon', max_token=1024, device='cpu'):
        from settings import MODELS_MAP
        from gpt4all import GPT4All

        self.model_name = os.path.basename(model_path)
        self.max_token = int(max_token)
        self.model = GPT4All(model_name=self.model_name, model_path=model_path, allow_download=False, device=device)



    def answer(self, user_question: str):
        '''
        generate answer from user question
        question must be a string with context and the question prompt
        '''
        prompt = user_question
        with self.model.chat_session():
            response = self.model.generate(prompt, max_tokens=self.max_token)
        return response.strip()
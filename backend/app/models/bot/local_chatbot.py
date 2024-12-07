class LocalChatbot:
    def __init__(self, model_name='gpt4all_falcon', device = 'intel', max_token=1024):
        from settings import MODELS_MAP
        from gpt4all import GPT4All

        self.model_name = model_name
        self.model_id = MODELS_MAP[model_name]
        self.device = device
        self.model = GPT4All(self.model_id, device='gpu')
        self.max_token = max_token



    def answer(self, user_question: str):
        '''
        generate answer from user question
        question must be a string with context and the question prompt
        '''
        prompt = user_question
        with self.model.chat_session():
            response = self.model.generate(prompt, max_tokens=self.max_token)
        return response.strip()
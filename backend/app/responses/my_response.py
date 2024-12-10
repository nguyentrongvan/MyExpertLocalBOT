from flask import make_response, jsonify

class MyResponse:
    def __init__(self, data=None, status_code=200, message=None, headers=None):
        """
        Custom response class to return structured responses.
        """
        self.data = data
        self.status_code = status_code
        self.message = message
        self.headers = headers if headers else {}

    def to_dict(self):
        """
        Convert response to a dictionary (useful for JSON responses).
        """
        response = {'status_code': self.status_code}
        if self.message:
            response['message'] = self.message
        if self.data is not None:
            response['data'] = self.data
        return response

    def get_response(self):
        """
        Generate the response object, which can be returned in Flask route.
        """
        response_data = self.to_dict()
        response = make_response(jsonify(response_data), self.status_code)
        for key, value in self.headers.items():
            response.headers[key] = value
        return response
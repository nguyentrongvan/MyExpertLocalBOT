import os
from app import controllers
from flask import Flask, Blueprint
from settings import API_LOGGER, host, port, MODEL_NAME

def main(host, port, debug=False):
    logger = API_LOGGER
    app = Flask(__name__)
    logger.info(f'Init api app...')
    logger.info(f'Init chatbot: {MODEL_NAME}')

    for attr in dir(controllers):
        value = getattr(controllers, attr)
        if not isinstance(value, Blueprint): continue
        app.register_blueprint(value)
        logger.info(f'Register blueprint: {value}')
        logger.info(f'Endpoint configuration: {app.url_map}')

    env = os.environ.get("STAGE")
    logger.info(f'Start app on host: {host}, port: {port}, env: {env}')
    if env == "DEV":
        app.run(host=host, port=port, debug=debug)
    elif env == "PROD":
        import waitress
        waitress.serve(app, host=host, port=port)
    else:
        raise(f"Environment is not correct: {env}")


if __name__ == '__main__':
    import argparse
    parser = argparse.ArgumentParser()
    parser.add_argument('-H', '--host', type=str, default=host)
    parser.add_argument('-P', '--port', type=int, default=port)
    args = parser.parse_args()
    main(host = args.host, port = args.port)
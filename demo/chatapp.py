import subprocess
import time

frontend_app = "client/ChatbotGUI.exe"
api_app = "server/BOTServer.exe"

subprocess.Popen(
    api_app,
    creationflags=subprocess.CREATE_NO_WINDOW
)

subprocess.Popen(frontend_app)

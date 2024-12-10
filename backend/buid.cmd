@echo off

REM Start build app
pyinstaller --noconfirm --onefile --console --icon=app/resource/app.ico --name BOTServer --add-data "app;app/" --add-data "settings.py;." --add-data ".env;." --hidden-import "pandas" --hidden-import "faiss" --hidden-import "pdfplumber" --hidden-import "logging.handlers" --hidden-import "dotenv" --hidden-import "flask" --hidden-import "docx" --hidden-import "tqdm" --hidden-import "uuid" --hidden-import "gpt4all" --hidden-import "waitress" --hidden-import "light_embed" --add-binary "venv/Lib/site-packages/gpt4all/llmodel_DO_NOT_MODIFY/build/*;gpt4all/llmodel_DO_NOT_MODIFY/build" run_api.py

REM Copy .ev file
echo Copying .env to dist folder
set "DIST_FOLDER=dist"
if exist "%DIST_FOLDER%" (
    copy ".env" "%DIST_FOLDER%\"
    if %errorlevel% equ 0 (
        echo Finished!
    ) else (
        echo Error when copy .env file.
    )
) else (
    echo Folder %DIST_FOLDER% not existed!
)

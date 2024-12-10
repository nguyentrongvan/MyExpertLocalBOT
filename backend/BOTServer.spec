# -*- mode: python ; coding: utf-8 -*-


a = Analysis(
    ['run_api.py'],
    pathex=[],
    binaries=[('venv/Lib/site-packages/gpt4all/llmodel_DO_NOT_MODIFY/build/*', 'gpt4all/llmodel_DO_NOT_MODIFY/build')],
    datas=[('app', 'app/'), ('settings.py', '.'), ('.env', '.')],
    hiddenimports=['pandas', 'faiss', 'pdfplumber', 'logging.handlers', 'dotenv', 'flask', 'docx', 'tqdm', 'uuid', 'gpt4all', 'waitress', 'light_embed'],
    hookspath=[],
    hooksconfig={},
    runtime_hooks=[],
    excludes=[],
    noarchive=False,
    optimize=0,
)
pyz = PYZ(a.pure)

exe = EXE(
    pyz,
    a.scripts,
    a.binaries,
    a.datas,
    [],
    name='BOTServer',
    debug=False,
    bootloader_ignore_signals=False,
    strip=False,
    upx=True,
    upx_exclude=[],
    runtime_tmpdir=None,
    console=True,
    disable_windowed_traceback=False,
    argv_emulation=False,
    target_arch=None,
    codesign_identity=None,
    entitlements_file=None,
    icon=['app\\resource\\app.ico'],
)

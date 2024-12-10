
# My Expert Local BOT

## Overview

**My Expert Local BOT** is a privacy-focused, fast, and efficient chatbot solution that combines **Qwen-2** and **FAISS** to build a Retrieval-Augmented Generation (RAG) chatbot. It is designed for local deployment, ensuring user data remains secure on their personal devices.

### Key Features
- **RAG Chatbot**: Leverages Qwen-2 and FAISS for advanced information retrieval and conversational AI.
- **Fast Query Processing**: Optimized for quick responses.
- **Runs on CPU**: Suitable for setups without GPU.
- **User Privacy**: Data is stored locally on the user's PC.

### Performance
- **Fast and Efficient**: Works seamlessly on CPU or GPU.
- **Optimized for GPU**: Tested with NVIDIA 2080 Ti for maximum efficiency.

---

## Environment Setup

### Backend
1. Navigate to the backend directory:
   ```bash
   cd backend
   ```
2. Create a virtual environment:
   ```bash
   virtualenv venv
   ```
3. Install required dependencies:
   ```bash
   pip install -r requirements.txt
   ```
4. Build the executable:
   ```bash
   pyinstaller BOTServer.spec
   ```

### GUI
1. Use **Visual Studio** with **WinForm** and **.NET 4.7** to build the user interface.

---

## Demo
![Demo GUI](/demo/demoapp.gif)

---


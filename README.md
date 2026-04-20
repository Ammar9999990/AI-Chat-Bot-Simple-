# AI Chatbot Simple

A simple, lightweight Windows Forms (WinForms) application that acts as an AI chatbot using the Google Gemini 2.5 Flash API. 

## 🚀 Features
* **Simple Interface:** Clean UI built with Visual Studio Designer using a Form.
* **Smart AI Responses:** Powered by Google's Gemini 2.5 Flash API.
* **Chat History:** Displays an ongoing conversation in a scrollable chat box.
* **Easy to Setup:** Requires minimal configuration.

## 🛠️ Built With
* **C# / .NET**
* **Windows Forms (WinForms)**
* **Newtonsoft.Json** (For handling API requests and responses)
* **Google Gemini API** 

## ⚙️ How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/Ammar9999990/AI-Chat-Bot-Simple-.git
2. Open the solution file (AIChatbotApp.sln) in Visual Studio.
3. Make sure the Newtonsoft.Json NuGet package is installed. (You can restore packages by right-clicking the solution and selecting "Restore NuGet Packages").
4. Important: Open Form1.cs and replace the API Key placeholder with your own Google Gemini API key:
csharp
  // Replace with your actual Gemini API Key
  string apiKey = "YOUR_API_KEY_HERE";
5. Build and run the project (F5).


💡 Usage
Type your prompt into the text box at the bottom.
Click the Send button.
Wait a moment for the AI to process and display the response in the main chat window.

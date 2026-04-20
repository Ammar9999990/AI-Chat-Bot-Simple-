using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AIChatbotApp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        // 🔑 API KEY HERE
        string apiKey = "[ENCRYPTION_KEY]";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;

            if (string.IsNullOrWhiteSpace(userInput))
                return;

            rtbChat.AppendText("You: " + userInput + "\n");
            txtInput.Clear();

            try
            {
                string response = await GetAIResponse(userInput);
                rtbChat.AppendText("AI: " + response + "\n\n");
            }
            catch (Exception ex)
            {
                rtbChat.AppendText("Error: " + ex.Message + "\n\n");
            }

            rtbChat.SelectionStart = rtbChat.Text.Length;
            rtbChat.ScrollToCaret();
        }

        private async Task<string> GetAIResponse(string prompt)
        {
            string url = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";

            var requestBody = new
            {
                contents = new[]
                {
            new
            {
                parts = new[]
                {
                    new { text = prompt }
                }
            }
        }
            };

            var json = JsonConvert.SerializeObject(requestBody);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();

          


            dynamic result = JsonConvert.DeserializeObject(responseString);

            // 🔥 SAFE CHECK
            if (result.candidates == null)
                throw new Exception("No candidates returned:\n" + responseString);

            return result.candidates[0].content.parts[0].text.ToString();
        }
        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
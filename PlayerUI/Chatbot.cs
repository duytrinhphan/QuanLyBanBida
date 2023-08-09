using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net.Http;
using System.Net.Http.Headers;


namespace QuanLyBanBida
{
    public partial class Chatbot : Form
    {
        private const string YOUR_API_KEY = "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";
        public Chatbot()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string userInput = txt_Question.Text;
            rtb_Chatbox.AppendText("Tôi: " + userInput + Environment.NewLine);
            string response = GetChatbotResponse(userInput);
            rtb_Chatbox.AppendText("Chatbot: " + response + Environment.NewLine);
        }

        private string GetChatbotResponse(string input)
        {
            var client = new RestClient("https://api.openai.com/v1");
            var request = new RestRequest("engines/davinci/completions", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {YOUR_API_KEY}");
            request.AddJsonBody(new
            {
                prompt = input,
                max_tokens = 100,
                temperature = 0.7
            });

            var response = client.Execute(request);
            var responseData = JObject.Parse(response.Content);
            string output = responseData["choices"][0]["text"].ToString();

            return output;
        }
    }
}

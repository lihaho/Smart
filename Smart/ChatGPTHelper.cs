using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Smart
{
    public class ChatGPTHelper
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public ChatGPTHelper(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public string GetChatGPTResponse(string prompt)
        {
            var requestBody = new
            {
                model = "gpt-4o",
                messages = new[]
                {
                new { role = "user", content = prompt }
            },
                max_tokens = 150
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = _httpClient.PostAsync("https://uiuiapi.com/v1/chat/completions", content).Result;
            response.EnsureSuccessStatusCode();

            var responseBody = response.Content.ReadAsStringAsync().Result;
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);
            return jsonResponse.choices[0].message.content.ToString().Trim();
        }
    }
}

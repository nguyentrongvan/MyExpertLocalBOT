using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ChatbotGUI.Services
{
    internal class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        public class ApiResponse
        {
            public string status_code;
            public string data;
            public string message;
        }

        public static async Task<ApiResponse> CreateBot(List<string> filePaths, string botId = null, string botName = null)
        {
            // API Endpoint
            string url = "http://127.0.0.1:5557/v1/create-bot";

            try
            {
                using (var content = new MultipartFormDataContent())
                {
                    foreach (var filePath in filePaths)
                    {
                        var fileContent = new ByteArrayContent(File.ReadAllBytes(filePath));
                        content.Add(fileContent, "files", Path.GetFileName(filePath));
                    }

                    // Add bot_id if exist to the request
                    if (botId != null)
                    {
                        content.Add(new StringContent(botId), "bot_id");
                    }
                    if (botName != null)
                    {
                        content.Add(new StringContent(botName), "bot_name");
                    }

                    // Send POST request
                    var response = await client.PostAsync(url, content);

                    // Ensure the response is successful
                    response.EnsureSuccessStatusCode();

                    // Return the response body
                    string stringRes = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(stringRes);
                    return apiResponse;

                }
            }
            catch (Exception ex)
            {
                // Log and rethrow exception
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }


        public static async Task<ApiResponse> Conversation(string userQuestion, string botId)
        {
            // API Endpoint
            string url = "http://127.0.0.1:5557/v1/conversation";
            var jsonData = new
            {
                user_question = userQuestion,
                bot_id = botId
            };

            try
            {
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string stringRes = await response.Content.ReadAsStringAsync();
                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(stringRes);
                return apiResponse;
            }
            catch (Exception ex)
            {
                // Log and rethrow exception
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }


        public static async Task<List<Dictionary<string, string>>> GetAllBots()
        {
            string url = "http://127.0.0.1:5557/v1/get-all-bots";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var allBots = Commands.CommonFunctions.ParseBotData(content);
                        return allBots;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }


        public static async Task<bool> HeathCheck()
        {
            string url = "http://127.0.0.1:5557/v1/health-check";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }


        public static async Task CloseBOTServer()
        {
            string url = "http://127.0.0.1:5557/v1/self-kill";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}

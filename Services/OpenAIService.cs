using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace BlazorAI.Services
{
    public class OpenAIService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiKey;

        public OpenAIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetResponseFromAzureOpenAI(string prompt)
        {
            var requestContent = new
            {
                messages = new[]
                {
                    new { role = "system", content = "You are a helpful assistant." },
                    new { role = "user", content = prompt }
                }
            };

            var httpClient = _httpClientFactory.CreateClient();
            var requestBody = new StringContent(JsonSerializer.Serialize(requestContent), Encoding.UTF8, "application/json");

            // Azure OpenAI endpoint and API key
            var azureEndpoint = "your-azure-endpoint-url";
            var azureApiKey = "your-api-key";

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", azureApiKey);
            httpClient.DefaultRequestHeaders.Add("api-key", azureApiKey); // Adding the API key in headers
            httpClient.DefaultRequestHeaders.Add("User-Agent", "azure-openai-client"); // Optional user agent header
            var response = await httpClient.PostAsync(azureEndpoint, requestBody);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var jsonResponse = JsonDocument.Parse(responseContent);

            return jsonResponse.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
        }
    }
}
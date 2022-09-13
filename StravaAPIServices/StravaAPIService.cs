using System.Security.Cryptography.X509Certificates;

namespace StravaAPIServices
{
    public class StravaAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<string> GetLoggedInAthlete(string url)
        {
            return await GetAsync<string>(url);
                
        }

        private async Task<T> GetAsync<T>(string url) where T: class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // if(response.IsS)
            return default;
        }
    }
}
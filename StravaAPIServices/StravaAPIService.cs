using StravaAPIModels.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;

namespace StravaAPIServices
{
    public class StravaAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public StravaAPIService()
        {

        }

        public StravaAPIService(string bearerToken)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", bearerToken);
        }

        //Specific GET call
        public async Task<LoggedInAthleteModel> GetLoggedInAthlete(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await _httpClient.GetAsync("https://www.strava.com/api/v3/athlete");

            return (response.IsSuccessStatusCode && response.Content != null)
                    ? await response.Content.ReadAsAsync<LoggedInAthleteModel>()
                    : null;                
        }


        //Generic GET call
        private async Task<T> GetAsync<T>(string url) where T: class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // if(response.IsS)
            return default;
        }

        public async Task<List<AthleteActivity>> GetAthleteActivity(string token)
        {
            var u = "https://www.strava.com/api/v3/athlete/activities";
           
            var builder = new UriBuilder(u);
            builder.Query = "before=1672504919&after=1641055319";
            var url = builder.ToString();

            _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            return (response.IsSuccessStatusCode && response.Content != null)
                    ? await response.Content.ReadAsAsync<List<AthleteActivity>>()
                    : null;


        }

    }
}
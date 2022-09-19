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

            //if(response.IsSuccessStatusCode)
            //{
            //    LoggedInAthleteModel loggedInAthlete = await response.Content.ReadAsAsync<LoggedInAthleteModel>();
            //}

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

    }
}
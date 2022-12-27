using StravaAPIModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StravaAPIModels.Library.Models.Authorization;

namespace ThirdPartyAPIAccess
{
    public class StravaAPIAuthHelper
    {
        private readonly HttpClient _httpClient = new HttpClient();


        //need to check to see if token is still good and refresh if not.       

        public async Task RefreshToken(AccessToken token)
        {

            _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await _httpClient.GetAsync("https://www.strava.com/api/v3/athlete");

            return (response.IsSuccessStatusCode && response.Content != null)
                    ? await response.Content.ReadAsAsync<LoggedInAthleteModel>()
                    : null;
        }
    }
}

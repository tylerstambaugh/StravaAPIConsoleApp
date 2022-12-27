using StravaAPIModels.Library.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaDAL
{
    public class SeedData
    {
        public void Seed()
        {
            AuthorizationTokenRepo authRepo = new AuthorizationTokenRepo();

            AccessToken token = new AccessToken()
            {
                AthleteId = 381648,
                Token = "2e4a23c4b680dfd84d3d1c4dc6a5f3057c666886",
                RefreshToken = "a05f83eaea4dccfab18a8e24ecccb37c33e38072",
                ExpiresAt = 1672197822,
                ExpiresIn = 20930
            };

            authRepo.AddToken(token);
        }
    }
}

using StravaAPIModels.Library.Models.Authorization;
using StravaAPIModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaDAL
{
    public class AuthorizationTokenRepo
    {
        private readonly List<AccessToken> _tokenRepo = new List<AccessToken>();

        public bool AddToken(AccessToken token)
        {
            if (token == null)
            {
                return false;
            }

            _tokenRepo.Add(token);
            return true;
        }
    }
}

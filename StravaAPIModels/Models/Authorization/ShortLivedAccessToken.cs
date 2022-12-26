using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaAPIModels.Library.Models.Authorization
{
    public class ShortLivedAccessToken
    {
        public int AthleteId { get; set; }
        public bool Scope { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}

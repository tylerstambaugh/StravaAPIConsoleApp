using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaAPIModels.Library.Models.Authorization
{
    public class AccessToken
    {
        public int AthleteId { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public long ExpiresAt { get; set; }
        public long ExpiresIn { get; set; }
    }
}

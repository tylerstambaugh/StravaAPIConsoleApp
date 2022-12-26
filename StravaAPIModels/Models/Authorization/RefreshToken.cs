using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaAPIModels.Library.Models.Authorization
{
    public class RefreshToken
    {
        public int AthleteId { get; set; }
        public string RefreshTokenCode { get; set; }
        public bool Scope { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaAPIModels.Models
{
    public class StravaMap
    {
        public string id { get; set; }
        public object summary_polyline { get; set; }
        public int resource_state { get; set; }
    }
}

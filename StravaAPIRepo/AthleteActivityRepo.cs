using StravaAPIModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaDAL
{
    public  class AthleteActivityRepo
    {
        private readonly List<AthleteActivity> _athleteRepo = new List<AthleteActivity>();
        private int _count = 0;
        //private readonly List<ShoesModel> _shoesRepo = new List<ShoesModel>();
        //private readonly List<BikeModel> _bikeRepo = new List<BikeModel>();

        public bool AddLoggedInAthlete(AthleteActivity activity)
        {
            if (activity == null)
            {
                return false;
            }

            _count++;
            activity.id = _count;
            _athleteRepo.Add(activity);
            return true; 
        }
    }
}

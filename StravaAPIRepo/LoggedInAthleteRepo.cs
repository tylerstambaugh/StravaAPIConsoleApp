using StravaAPIModels.Models;

namespace StravaAPIRepo
{
    public class LoggedInAthleteRepo
    {
        private readonly List<LoggedInAthleteModel> _athleteRepo = new List<LoggedInAthleteModel>();
        private int _count = 0;
       //private readonly List<ShoesModel> _shoesRepo = new List<ShoesModel>();
        //private readonly List<BikeModel> _bikeRepo = new List<BikeModel>();

        public bool AddLoggedInAthlete(LoggedInAthleteModel loggedInAthlete)
        {
            if (loggedInAthlete == null)
            {
                return false;
            }

            _count++;
            loggedInAthlete.id = _count;
            _athleteRepo.Add(loggedInAthlete);
            return true;
        }

    }
}
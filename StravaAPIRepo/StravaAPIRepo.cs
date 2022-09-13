using StravaAPIModels.Models;

namespace StravaAPIRepo
{
    public class StravaAPIRepo
    {
        private readonly List<LoggedInAthleteModel> _athleteRepo = new List<LoggedInAthleteModel>();
        private readonly List<ShoesModel> _shoesRepo = new List<ShoesModel>();
        private readonly List<BikeModel> _bikeRepo = new List<BikeModel>();

    }
}
using StravaAPIModels.Models;
using StravaAPIServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaConsoleApp
{
    public class ProgramUI
    {
        StravaAPIService _stravaApiService = new StravaAPIService();
        public void Run()
        {
            {
                //seed data?

            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Strava API Console App \n" +
                "Please select an option \n" +
                "\n" +
                "1. View Athletes \n" +
                "2. View Athlete Activities \n" +
                "99. Exit");
        }

        public void RunApplication()
        {
            bool runApplication = true;

            while (runApplication)
            {
                DisplayMenu();
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAthletes();
                        break;
                    case "2":
                        ViewAthleteActivity();
                        break;
                    case "99":
                        if (ConfirmExit())
                        {
                            runApplication = false;
                        }
                        break;
                    default:
                        InvalidSelection();
                        break;
                }
            }
        }

        private void InvalidSelection()
        {
            Console.WriteLine("Please make a valid selection.");
        }

        private bool ConfirmExit()
        {
            Console.WriteLine("Are you sure you want to exit y/n?");
            var userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
                return true;
            else return false;
        }

        private void ViewAthletes()
        {
            Console.WriteLine("Please enter the athlete ID you'd like to view and press enter:");

            var userInput = Console.ReadLine();
            string token = "45fdaf3307debbee41dcd03bf86ca30307d94d0d";
            LoggedInAthleteModel loggedInAthlete = _stravaApiService.GetLoggedInAthlete(token).Result;

            Console.WriteLine($"{loggedInAthlete.firstname} {loggedInAthlete.lastname}");

            Console.WriteLine();
        }

        private void ViewAthleteActivity()
        {
            Console.WriteLine("Please enter the athlete ID you'd like to view and press enter:");

            var userInput = Console.ReadLine();
            string token = "45fdaf3307debbee41dcd03bf86ca30307d94d0d";
            List<AthleteActivity> athleteActivityModelList = _stravaApiService.GetAthleteActivity(token).Result;

            foreach(AthleteActivity activity in athleteActivityModelList)
            {

            }

            Console.WriteLine($"Total Activities returned{athleteActivityModelList.Count}");

            Console.WriteLine();
        }
    }
}

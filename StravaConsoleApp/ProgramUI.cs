using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaConsoleApp
{
    public  class ProgramUI
    {

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
                "00. Exit");
        }

        public void RunApplication()
        {
            bool runApplication = true;

            while(runApplication)
            {
                DisplayMenu();
                var userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        ViewAthletes();
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
            throw new NotImplementedException();
        }
    }
}

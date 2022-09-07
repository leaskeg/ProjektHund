using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektHund
{
    public class Dogs
    {
        public double rangeHdIndex;
        public void Menu()
        {
            //Creating Console.WriteLine to communicate with our user and give them menu options
            Console.WriteLine("Welcome to Boxer-Klubben \n\nChoose an option\n1. Search for HD-Index");
            //Instanciating setChoice which controls our menu
            setChoice();

        }

        public void setChoice()
        {
            //string choice to get userInput into our switch case
            string choice = Console.ReadLine();
            //Clear to make it look PRETTY and SPARKLY
            Console.Clear();
            //switch case to control our users choices in the Menu
            //Our choice parameter is our userInput string
            switch (choice)
            {
                case "1":
                    //instanciates getRange from its class, so we can see what the user enters as range
                    getRange();
                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                default:

                    break;
            }
        }

        //Creating a getRange Method to control the userInput, this stems from DCD-model
        public void getRange()
        {
            //Creating a Console.Writeline to commuicate with the user
            Console.WriteLine("Enter HD-Index range");
            //instanciating setRange method which will take the user input
            setRange();
        }

        //Creating setRange method to take userInput, this stems from our DCD-model
        public void setRange()
        {
            //Setting rangeHdIndex = to UserInput to be able to get information from our user
            rangeHdIndex = Convert.ToDouble(Console.ReadLine());
        }



















    }
}

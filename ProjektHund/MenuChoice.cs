using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektHund
{
    //Creating MenuChoice Class to control the choices our user makes in the Menu
    public class MenuChoice
    {
        //Creating setChoice Method to control our Menu, this stems from our DCD-model
        public void setChoice()
        {
            //Creating a new instance of our RangeSearch class to be able to use getRange which controls the range the user types in
            RangeSearch rangeSearch = new RangeSearch();
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
                    rangeSearch.getRange();
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

    }
}

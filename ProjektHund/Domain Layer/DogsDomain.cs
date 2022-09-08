using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjektHund.Technical_Layer;

namespace ProjektHund.Domain_Layer
{
    public class DogsDomain
    {
        public void setChoice()
        {
            DogsTechnical dogsTechnical = new DogsTechnical();
            
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
                    dogsTechnical.getRange();
                    break;

                case "2":
                    dogsTechnical.getInformations();
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

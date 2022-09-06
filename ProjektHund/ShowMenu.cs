using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektHund
{
    //Creating ShowMenu Class which stems from our DCD-Model
    public class ShowMenu
    {
        //Creating Menu Method to show our menu to the user, this stems from our DCD-model
        public void Menu()
        {
                //creating a new instansering of MenuChoice Class
                MenuChoice menuChoice = new MenuChoice();
                //Creating Console.WriteLine to communicate with our user and give them menu options
                Console.WriteLine("Welcome to Boxer-Klubben \n\nChoose an option\n1. Search for HD-Index");
                //Instanciating setChoice which controls our menu
                menuChoice.setChoice();

        }

    }
}

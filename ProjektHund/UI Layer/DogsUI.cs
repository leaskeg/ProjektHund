using ProjektHund.Technical_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektHund.Domain_Layer;

namespace ProjektHund.UI_Layer
{
    class DogsUI : DogsTechnical
    {

		static void Main(string[] args)
		{
			DogsDomain dogsDomain = new DogsDomain();
			dogsDomain.setChoice();
        }

		public void ShowMenu()
		{
			//Creating Console.WriteLine to communicate with our user and give them menu options
			Console.WriteLine("Welcome to Boxer-Klubben \n\nChoose an option\n1. Search for HD-Index\n2. Create A Dog\n3. Exit");
		}

		public void ShowDogList()
		{
			
			DogsTechnical dogsTechnical = new DogsTechnical();
			dogsTechnical.getRange();
		}

		public void ShowChoice()
		{
			DogsDomain dogsDomain = new DogsDomain();
			//Instanciating setChoice which controls our menu
			dogsDomain.setChoice();
		}

		public void ShowConfirmation()
		{
            Console.WriteLine("The dog has been saved in the database");
        }
	}
}

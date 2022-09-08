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
		public string name { get; set; }
		public string pedigreeNumber { get; set; }
		public DateTime birthdate { get; set; }
		public string gender { get; set; }
		public string breeder { get; set; }
		public string chipNumber { get; set; }
		public string fathersPedigreeNumber { get; set; }
		public string mothersPedigreeNumber { get; set; }
		public string color { get; set; }

		static void Main(string[] args)
		{
			DogsUI dogsUI = new DogsUI();
			dogsUI.ShowMenu();
			dogsUI.ShowChoice();
			dogsUI.ShowDogList();
		}

		public void ShowMenu()
		{
			//Creating Console.WriteLine to communicate with our user and give them menu options
			Console.WriteLine("Welcome to Boxer-Klubben \n\nChoose an option\n1. Search for HD-Index\n2. Create Dog");
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

		public void Informations() 
		{
			Console.WriteLine("Enter Name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter pedigree number: ");
			pedigreeNumber = Console.ReadLine();
			Console.WriteLine("Enter birthdate: ");
			birthdate = Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("Enter gender: ");
			gender = Console.ReadLine();
			Console.WriteLine("Enter breeder: ");
			breeder = Console.ReadLine();
			Console.WriteLine("Enter chip number: ");
			chipNumber = Console.ReadLine();
			Console.WriteLine("Enter fathers pedigree number: ");
			fathersPedigreeNumber = Console.ReadLine();
			Console.WriteLine("Enter mothers pedigree number: ");
			mothersPedigreeNumber = Console.ReadLine();
			Console.WriteLine("Enter color: ");
			color = Console.ReadLine();

			ShowConfirmation();
		}

		public void ShowConfirmation()
		{
			Console.WriteLine("The dog has been saved with the followering information:");
		}
	}
}

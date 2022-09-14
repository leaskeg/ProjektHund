using Microsoft.VisualBasic;
using ProjektHund.UI_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjektHund.Technical_Layer
{
    public class DogsTechnical
    {
        public void getRange()
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Hunde;Trusted_Connection=True";

                //Promting the user to enter first range number
                Console.WriteLine("Enter first range number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second range number");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                conn.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM [dbo].[Grunddata$] WHERE HDindex BETWEEN {userInput} AND {userInput1}", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("Stambognr: [{0}], Name: [{1}], HDindex: [{2}]\n", reader.GetValue(1), reader.GetValue(3), reader.GetValue(17));
                        }
                    }
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                conn.Close();
            }
        }

        public void getInformations()
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                string ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hunde;Integrated Security=True";

                //Promting the user to enter first range number
                Console.WriteLine("Enter the dogs name: ");
                string userInputDogName = Console.ReadLine();
                bool check = true;
                while (check)
                {
                    if (Regex.IsMatch(userInputDogName, @"^[\p{L}\p{N}]+$"))
                    {
                        Console.WriteLine("Valid password.");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Error: A name cannot contain special characters!\nYou will now be returned to the main menu");
                        Console.ReadLine();
                        return;
                    }
                }

                


                Console.Clear();
                Console.WriteLine("Enter the dogs pedigree number: ");
                string userInputDogPedigree = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the dogs birthdate: \n(Example: 26-09-2022)");
                string userInputDogBirthdate = Console.ReadLine(); //Should be DateTime, but crashes with SQL database, find a fix for next sprint
                Console.Clear();
                Console.WriteLine("Enter the dogs gender: ");
                string userInputDogGender = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the dogs breeder: ");
                string userInputDogBreeder = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the dogs chip number: \n(If chip number does not exsist, type: 0) ");
                string userInputDogChipNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the fathers pedigree number: ");
                string userInputFathersPedigreeNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the dogs mothers pedigree number: ");
                string userInputMothersPedigreeNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the dogs color\nType the color as one one of the followering: \n(Rg,Tg,Rg/Hv,Tg/hv)\n (if unwanted color simply press Enter: )");
                string userInputDogColor = Console.ReadLine();
                Console.Clear();

                bool repeat = true;
                while (repeat)
                {
                    Console.WriteLine($"This was the information you entered\n\nName: {userInputDogName}\nPedigree Number: {userInputDogPedigree}\nBirthDate: {userInputDogBirthdate} \nGender: {userInputDogGender}\nBreeder: {userInputDogBreeder}\nChip Number: {userInputDogChipNumber}\nFathers Pedigree Number: {userInputFathersPedigreeNumber}\nMothers Pedigree Number: {userInputMothersPedigreeNumber}\nColor: {userInputDogColor}");
                    Console.WriteLine("Do you want to save this dog in the database?\n\nPress 'Enter' to save or Press 'Backspace' to return to menu");
                    var Choice = Console.ReadKey().Key;

                    switch (Choice)
                    {
                        case ConsoleKey.Enter:
                            DogsUI dogsUI = new DogsUI();

                            dogsUI.ShowConfirmation();

                            string commandText = $"INSERT INTO [dbo].[Grunddata$] (navn, Stambog, born, sex, breeder, Tato, far, mor, farve,  ) VALUES ('{userInputDogName}', '{userInputDogPedigree}','{userInputDogBirthdate}','{userInputDogGender}','{userInputDogBreeder}','{userInputDogChipNumber}','{userInputFathersPedigreeNumber}','{userInputMothersPedigreeNumber}','{userInputDogColor}');";
                            using (SqlConnection con = new SqlConnection(ConnectionString))
                            {
                                con.Open();

                                using (SqlCommand cmd = new SqlCommand(commandText, con))
                                    cmd.ExecuteNonQuery();
                                conn.Close();
                                repeat = false;
                            }
                            break;
                        case ConsoleKey.Backspace:
                            Console.WriteLine("You will now be returned to menu\nPress any key to continue...");
                            Console.ReadKey();
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Input. Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}

using Microsoft.VisualBasic;
using ProjektHund.UI_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
           /* using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Hunde;Trusted_Connection=True";

                //Promting the user to enter first range number
                Console.WriteLine("Enter first range number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second range number");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
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
                Console.ReadLine();
                conn.Close();
            }
        }
           */
        public void getInformations()
        {
            DogsUI dogsUI = new DogsUI();
            dogsUI.Informations();
        }
    }
}

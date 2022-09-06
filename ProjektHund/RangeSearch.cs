using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektHund
{
    //Creating a RangeSearch Class which stems from our DCD-model
    public class RangeSearch
    {
        //Creating a rangeHdIndex attribute, which stems from our DCD-model
        //This is used for setting the range later
        public double rangeHdIndex;

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

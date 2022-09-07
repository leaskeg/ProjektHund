using System.IO;

namespace ProjektHund

{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string data;
                FileStream fsSource = new FileStream("D:\\HundeData2.csv", FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fsSource))
                {
                    data = sr.ReadToEnd();
                }
                Console.WriteLine(data);
            }
                Dogs dogs = new Dogs();
                dogs.Menu();
        }
    }
}
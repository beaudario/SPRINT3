using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_2
{
    class Program
    {

        static bool IsWeekend()
        {
            //Get Local Time
            //DateTime now = new DateTime(2019, 03, 12);
            DateTime now = DateTime.Now;

            //Kijk of het weekend is of niet
            bool weekend;
            if ((now.ToString("dddd") == "Saturday") || (now.ToString("dddd") == "Sunday"))
            {
                weekend = true;
            }
            else
            {
                weekend = false;
            }
            //geef de output
            return weekend;
        }

        public static void Main(string[] args)
        {
            //Kijk naar de output van de methode
            if (IsWeekend() == true)
            {
                Console.WriteLine("Het is weekend!");

            }
            else
            {
                Console.WriteLine("Het is Doordeweeks!");
            }
        }
    }
}
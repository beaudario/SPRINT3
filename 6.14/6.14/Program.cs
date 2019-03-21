using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef geboortedatum (bijv. 03-07-1989): ");
            string birthday = Console.ReadLine();
            int birthday1 = int.Parse(birthday.Substring(6));

            Console.WriteLine("De leeftijd is: {0}", AgeCalc(birthday1));
            Console.ReadKey();
        }

        private static int AgeCalc(int bday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - bday;

            return age;
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Hey, geef een getal in en krijg de maand in het de taal corresponderend met het getal.");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("1. Nederlands");
            1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2. Duits");
            Console.WriteLine("3. Engels");
            Console.WriteLine("4. Frans");
            Console.WriteLine("5. Spaans");
            Console.WriteLine("6. Italiaans");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Geef hieronder een getal in.");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.ReadLine();
            string Nummer;
            Nummer = Console.ReadLine();
            DateTime maand = DateTime.Now();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Jouwn keuze is: " + Maand);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            //Eerst tijd naar nu zetten, daarna userinput laten herkennen qua getallen. Daarna If statement voor 6 branches.//
            
            
        }
    }
}

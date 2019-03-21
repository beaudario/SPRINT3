using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo wij geven een random naam van ons groepje weer.");
            string[] random = new string[4] { "Renzo", "Dario", "Jesse", "Mohammed"};

            Random rand = new Random();
            int index = rand.Next(random.Length);
            Console.WriteLine($"Dit is het random geselecteerde groepslid: {random[index]}");
            Console.ReadKey();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ;


        }
    }
}

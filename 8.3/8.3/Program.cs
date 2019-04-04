using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef deelgetal: ");
            double Number = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Geef deler: ");
            double DivideNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (DivideNumber == 0)
            {
                Console.WriteLine("Wie deelt door nul is een snul!");
            }
            else
            {
                double DividedNumber = Number / DivideNumber;
                Console.WriteLine("{0} / {1} = {2}", Number, DivideNumber, DividedNumber);
            }            
            
            Console.ReadKey();
        }
    }
}

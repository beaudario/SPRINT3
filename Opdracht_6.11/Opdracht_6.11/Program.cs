
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Opdracht_6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double minSom;
            Double plusSom;
            Double deelSom;
            Double keerSom;
            Double moduloSom;
            Console.WriteLine("Type het eerste getal: ");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type het tweede getal: ");
            Double y = Convert.ToDouble(Console.ReadLine());
            Calculate(Convert.ToDouble(x), Convert.ToDouble(y), out plusSom, out minSom, out deelSom, out keerSom, out moduloSom);
            {
                Console.WriteLine(x + " + " + y + " = {0}\n" +
                                  x + " - " + y + " = {1}\n" +
                                  x + " / " + y + " = {2}\n" +
                                  x + " * " + y + " = {3}\n" +
                                  x + " % " + y + " = {4}",
                                  plusSom, minSom, deelSom, keerSom, moduloSom);
            }
            Console.ReadKey();

            
        }

        public static void Calculate(Double x, Double y, out Double plusSom, out Double minSom, out Double deelSom, out Double keerSom, out Double moduloSom)
        {
            plusSom = x + y;
            minSom = x - y;
            deelSom = x / y;
            keerSom = x * y;
            moduloSom = x % y;
            
        }
   
         
    }
}


        
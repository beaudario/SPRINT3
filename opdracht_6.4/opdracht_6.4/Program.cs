using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace opdracht_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type het eerste gatal: ");
            Double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type het tweede gatal: ");
            Double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is het +, -, *, /, of %");
            Char som = Convert.ToChar(Console.ReadLine());

            switch (som)
            {
                case '*': Console.WriteLine(getal1 * getal2); break;
            }
            switch (som)
            {
                case '+': Console.WriteLine(getal1 + getal2); break;
            }
            switch (som)
            {
                case '-': Console.WriteLine(getal1 - getal2); break;
            }
            switch (som)
            {
                case '/': Console.WriteLine(getal1 / getal2); break;
            }
            switch (som)
            {
                case '%': Console.WriteLine(getal1 % getal2); break;
            }
            return;

        }
        public struct Calculate
        {
            public extern Calculate(Double getal1, Double getal2, Char som);
        }
        
        
    }
}

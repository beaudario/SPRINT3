using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInput
            Console.Write("Geef een woord om te versleutelen: ");
            string Input = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Geef een key (min./max. de lengte van het woord die word versleuteld): ");
            string Key = Console.ReadLine();
            Console.WriteLine();

            //ShowResult
            Console.Write("Het versleutelde woord is: {0}", Encrypter(Input, Key));
            Console.ReadKey();
        }

        //Method
        public static string Encrypter(string Input, string Key)
        {
                       
        }
    }
}

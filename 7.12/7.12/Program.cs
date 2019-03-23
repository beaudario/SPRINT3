using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string Input = Console.ReadLine();
            string Input1 = Input.ToUpper();
            Console.WriteLine();

            Console.Write("Geef een key: ");
            int Key = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Het ge-encrypte woord is: ");
            Console.Write(Encrypter(Input1, Key));
            Console.ReadKey();
        }

        private static string Encrypter(string Input2, int Shift)
        {
            string output = null;
            char[] A = null;
            A = Input2.ToCharArray();
            int temp;

            for (int i = 0; i < Input2.Length; i++)
            {
                temp = (int)(A[i] + Shift);
                output += (char)temp;
            }

            return output;
        }

    }
}

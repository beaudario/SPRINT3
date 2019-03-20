using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een nummer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De som van de individuele getallen van het nummer {0} is {1}", number, SumCal(number));
            Console.ReadKey();
        }

        private static int SumCal(int num)
        {
            string num1 = Convert.ToString(num);
            int sum = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                sum += Convert.ToInt32(num1.Substring(i, 1));
            }
            return sum;
        }
    }
}

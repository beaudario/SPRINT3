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
            //UserInput
            Console.Write("Geef een nummer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //ShowResult
            Console.WriteLine("De som van de individuele getallen van het nummer {0} is {1}", number, SumCal(number));
            Console.ReadKey();
        }

        //Method
        private static int SumCal(int num)
        {
            //DeclaringVariables
            string num1 = Convert.ToString(num);
            int sum = 0;

            //ForLoop
            for (int i = 0; i < num1.Length; i++)
            {
                //Calculating
                sum += Convert.ToInt32(num1.Substring(i, 1));
            }

            //ReturnResult
            return sum;
        }
    }
}

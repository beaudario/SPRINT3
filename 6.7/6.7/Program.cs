using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel getallen mag de reeks bevatten? (geef aan in getallen): ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }

            Console.ReadKey();
        }

        public static int Fibonacci(int len)
        {
            int firstNum = 0;
            int secondNum = 1;
            
            for (int i = 0; i < len; i++)
            {
                int sum = firstNum;
                firstNum = secondNum;
                secondNum = sum + secondNum;
            }

            return firstNum;
        }
    }
}

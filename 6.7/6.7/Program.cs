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
            //UserInput
            Console.Write("Hoeveel getallen mag de reeks bevatten? (geef aan in getallen): ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            //ForLoop
            for (int i = 0; i < lenght; i++)
            {
                //ShowResult
                Console.Write("{0} ", Fibonacci(i));
            }

            Console.ReadKey();
        }

        //Method
        public static int Fibonacci(int len)
        {
            //DeclaringVariables
            int firstNum = 0;
            int secondNum = 1;
            
            //ForLoop
            for (int i = 0; i < len; i++)
            {
                //CalculatingFibonacci
                int sum = firstNum;
                firstNum = secondNum;
                secondNum = sum + secondNum;
            }

            //ReturnResult
            return firstNum;
        }
    }
}

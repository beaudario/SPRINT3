using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef eerste getal: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Geef tweede getal: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Swap(ref firstNumber, ref secondNumber);

            Console.WriteLine("Het eerste getal is nu {0}", firstNumber);
            Console.WriteLine("Het tweede getal is nu {0}", secondNumber);
            Console.ReadKey();
        }

        static void Swap(ref int firstNum, ref int secondNum)
        {
            firstNum = secondNum - firstNum;
            secondNum = secondNum - firstNum;
            firstNum = firstNum + secondNum;
        }
    }
}

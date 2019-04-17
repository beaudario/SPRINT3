using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInput
            Console.Write("Geef eerste nummer: ");
            var baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef tweede nummer: ");
            var exponent = Convert.ToInt32(Console.ReadLine());

            //SendParameterToMethod
            var sum = IntegerPower(baseNumber, exponent);

            //ShowResult
            Console.WriteLine("{0} tot de macht {1} is {2}", baseNumber, exponent, sum);
            Console.ReadLine();
        }
        
        //Method
        private static int IntegerPower(int baseNum, int expo)
        {
            //Calculating
            var result = 1;
            for (var i = 0; i < expo; i++)
            {
                result *= baseNum;
            }

            //ReturnResult
            return result;
        }

    }
}

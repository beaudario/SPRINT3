using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        //DeclaringNewRandom
        static Random r = new Random();

        static void Main(string[] args)

        {
            //ForLoop
            for (int i = 0; i < 100; i++)
            {
                //GeneratingRandomNumber
                long getal1 = r.Next(int.MaxValue);
                long getal2 = r.Next(int.MaxValue);

                //Calculating
                long product = getal1 * getal2;

                //ShowResult
                Console.WriteLine("{0} * {1} = {2}", getal1, getal2, product);
            }
            Console.ReadKey();
        }
    }
}
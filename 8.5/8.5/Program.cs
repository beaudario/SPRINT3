using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    class Program

    {
        static Random r = new Random();

        static void Main(string[] args)

        {
            for (int i = 0; i < 100; i++)
            {

                int getal1 = r.Next(int.MaxValue);
                int getal2 = r.Next(int.MaxValue);
                int product = getal1 * getal2;

                Console.WriteLine("{0} * {1} = {3}", getal1, getal2, product);
            }

            Console.ReadKey();
        }
    }
}
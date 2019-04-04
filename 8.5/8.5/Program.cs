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

                long getal1 = r.Next(int.MaxValue);
                long getal2 = r.Next(int.MaxValue);
                long product = getal1 * getal2;

                Console.WriteLine("{0} * {1} = {2}", getal1, getal2, product);
            }

            Console.ReadKey();
        }
    }
}
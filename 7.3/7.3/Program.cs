using System;

namespace _7._3Jesse
{
    class Program
    {
        public static int[] randomnummers = new int[25];
        static Random random = new Random();
        static void Main(string[] args)

        {
            Console.WriteLine("hier ziet u de even getallen");
            Console.ReadKey();
            for (int i = 0; i < randomnummers.Length; i++)
            {

                int num = random.Next(1, 10000);
                randomnummers[i] = num;
            }
            for (int i = 0; i < randomnummers.Length; i++)
            {
                if (randomnummers[i] % 2 == 0)
                {
                    Console.WriteLine(randomnummers[i]);
                }
            }
            Console.WriteLine("hier ziet u de oneven getallen");
            Console.ReadKey();
            for (int i = 0; i < randomnummers.Length; i++)
            {
                if (randomnummers[i] % 2 != 0)
                {
                    Console.WriteLine(randomnummers[i]);
                }

            }
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}


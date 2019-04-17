using System;

namespace _7._3Jesse
{
    class Program
    {
        //DeclaringNewRandomAndArray
        public static int[] randomnummers = new int[25];
        static Random random = new Random();
        static void Main(string[] args)
        {
            //ShowResult
            Console.WriteLine("hier ziet u de even getallen");
            Console.ReadKey();

            //ForLoop
            for (int i = 0; i < randomnummers.Length; i++)
            {
                //AddingRandomNumbersToArray
                int num = random.Next(1, 10000);
                randomnummers[i] = num;
            }

            //ForLoop
            for (int i = 0; i < randomnummers.Length; i++)
            {
                //IfStatement
                if (randomnummers[i] % 2 == 0)
                {
                    //ShowEvenNumbers
                    Console.WriteLine(randomnummers[i]);
                }
            }

            //ShowResult
            Console.WriteLine("hier ziet u de oneven getallen");
            Console.ReadKey();

            //ForLoop
            for (int i = 0; i < randomnummers.Length; i++)
            {
                //IfStatement
                if (randomnummers[i] % 2 != 0)
                {
                    //ShowOddNumbers
                    Console.WriteLine(randomnummers[i]);
                }

            }
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}


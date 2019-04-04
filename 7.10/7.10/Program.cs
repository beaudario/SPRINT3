using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = {
                "Dario Douma",
                "Jesse Radema",
                "Renzo Pieters",
                "Mohammed Yasin"
            };

            double[,] Grades = {
                {5.4, 7.0, 5.6},
                {5.5, 4.9, 5.7},
                {5.6, 7.2, 2.4},
                {1.0, 3.5, 5.5}
            };

            for (int i = 0; i < (Name.Length); i++)
            {
                double Sum = 0;

                for (int i1 = 0; i1 < 3; i1++)
                {
                    Sum += Grades[i, i1];
                }

                Sum += Grades[i, 2];
                double Average = Sum / 4;

                Console.WriteLine("{0}: \n", Name[i]);
                Console.WriteLine("Nederlands (weging 1): {0}", Grades[i, 0]);
                Console.WriteLine("Engels (weging 1): {0}", Grades[i, 1]);
                Console.WriteLine("Nederlands (weging 2): {0}", Grades[i, 2]);
                Console.WriteLine("Gemiddelde: {0}", Average);

                Console.WriteLine("*************************************** \n");
            }

            Console.ReadKey();
        }
    }
}

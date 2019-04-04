using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Info =
            {
                {"Dario Douma", "0311264", "25 November 2001", "Enschede"},
                {"Jesse Radema", "0310146", "26 Mei 2001", "Enschede"},
                {"Renzo Pieters", "a", "b", "Enschede"},
                {"Mohammed Yasin", "c", "d", "Enschede" }
            };

            for (int i = 0; i < (Info.Length / 4); i++)
            {
                Console.WriteLine("{0} ({1}) is geboren op {2} in {3}", Info[i, 0], Info[i, 1], Info[i, 2], Info[i, 3]);
            }
            Console.ReadKey();
        }
    }
}

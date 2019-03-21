 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Geef 5 getallen in. Wij geven jouwn keuzes weer.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Geef hieronder getal 1 in.");
            Console.WriteLine("-------------------------------------------------");
            int Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vul nu getal 2 in.");
            Console.WriteLine("-------------------------------------------------");
            int Getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vul nu getal 3 in.");
            Console.WriteLine("-------------------------------------------------");
            int Getal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vul nu getal 4 in.");
            Console.WriteLine("-------------------------------------------------");
            int Getal4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vul nu getal 5 in.");
            Console.WriteLine("-------------------------------------------------");
            int Getal5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("We hebben nu alle getallen deze gaan weergeven als een array.");
            Console.WriteLine("-------------------------------------------------");
            int[] array = new int[6];
            array[1] = Getal1;
            array[2] = Getal2;
            array[3] = Getal3;
            array[4] = Getal4;
            array[5] = Getal5;

            Console.WriteLine(array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array [5]);
            Console.ReadLine();
        }
    }
}

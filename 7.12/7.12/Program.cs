using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice();
        }

        public static void Choice()
        {
            Console.Write("\n ********************************** \n");
            Console.Write("[V]ersleutelen of [O]ntsleutelen: ");
            string VO = Console.ReadLine();

            if (VO == "V" || VO == "v")
            {
                Console.WriteLine("\n ********************************** \n");
                Encrypter();
            }

            else if (VO == "O" || VO == "o")
            {
                Console.WriteLine("\n ********************************** \n");
                Decrypter();
            }
        }

        public static void Encrypter()
        {
            Console.Write("Geef een woord om te versleutelen: ");
            string InputEn = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Geef een key: ");
            int KeyEn = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Het versleutelde woord is: ");
            Console.WriteLine(Encrypter1(InputEn, KeyEn));
            Console.ReadKey();
            Choice();
        }

        public static string Encrypter1(string Input, int Key)
        {
            string Output = null;
            char[] Letters = Input.ToCharArray(); ;
            int Temp;

            for (int i = 0; i < Input.Length; i++)
            {
                Temp = (int)(Letters[i] + Key);
                Output += (char)Temp;
            }

            return Output;
        }

        public static void Decrypter()
        {
            Console.Write("Geef een woord om te ontsleutelen: ");
            string InputDe = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Geef een key: ");
            int KeyDe = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Het ontsleutelde woord is: ");
            Console.WriteLine(Decrypter1(InputDe, KeyDe));
            Console.ReadKey();
            Choice();
        }

        public static string Decrypter1(string Input, int Key)
        {
            string Output = null;
            char[] Letters = Input.ToCharArray();
            int Temp;

            for (int i = 0; i < Input.Length; i++)
            {
                Temp = (int)(Letters[i] - Key);
                Output += (char)Temp;
            }

            return Output;
        }
    }
}

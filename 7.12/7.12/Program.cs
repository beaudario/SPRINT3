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
            //CallingMethod
            Choice();
        }

        //Method
        public static void Choice()
        {
            //UserInput
            Console.Write("\n ********************************** \n");
            Console.Write("[V]ersleutelen of [O]ntsleutelen: ");
            string VO = Console.ReadLine();

            //IfStatement
            if (VO == "V" || VO == "v")
            {
                //CallingMethod
                Console.WriteLine("\n ********************************** \n");
                Encrypter();
            }

            else if (VO == "O" || VO == "o")
            {
                //CallingMethod
                Console.WriteLine("\n ********************************** \n");
                Decrypter();
            }
        }

        public static void Encrypter()
        {
            //UserInput
            Console.Write("Geef een woord om te versleutelen: ");
            string InputEn = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Geef een key: ");
            int KeyEn = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //ShowResult
            Console.Write("Het versleutelde woord is: {0}", (Encrypter1(InputEn, KeyEn)));
            Console.WriteLine();
            Console.ReadKey();

            Choice();
        }

        //Method
        public static string Encrypter1(string Input, int Key)
        {
            //DeclaringVariablesAndArray
            string Output = null;
            char[] Letters = Input.ToCharArray(); ;
            int Temp;

            //ForLoop
            for (int i = 0; i < Input.Length; i++)
            {
                //Shift
                Temp = (int)(Letters[i] + Key);
                Output += (char)Temp;
            }

            //ReturnResult
            return Output;
        }

        //Method
        public static void Decrypter()
        {
            //UserInput
            Console.Write("Geef een woord om te ontsleutelen: ");
            string InputDe = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Geef een key: ");
            int KeyDe = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //ShowResult
            Console.Write("Het ontsleutelde woord is: {0}", (Decrypter1(InputDe, KeyDe)));
            Console.WriteLine();
            Console.ReadKey();

            //CallingMethod
            Choice();
        }

        //Method
        public static string Decrypter1(string Input, int Key)
        {
            //DeclaringVariablesAndArray
            string Output = null;
            char[] Letters = Input.ToCharArray();
            int Temp;

            //ForLoop
            for (int i = 0; i < Input.Length; i++)
            {
                //Unshift
                Temp = (int)(Letters[i] - Key);
                Output += (char)Temp;
            }

            //ReturnResult
            return Output;
        }
    }
}

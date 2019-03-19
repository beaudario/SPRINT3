using System;

namespace Opdracht_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput;
            Console.WriteLine("Vul een getal in voor het aantal lege regels dat u wilt: ");
            UserInput = Convert.ToInt32(Console.ReadLine());
            LegeRegels(UserInput);
            
        }


        public static void LegeRegels(int regels)
        {
           for(int i = 0;i <= regels ;i++)
            {
                Console.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}

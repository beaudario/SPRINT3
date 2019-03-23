using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Opdracht_6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een van de onderstaande opties: ");
            Console.WriteLine("1. Baligator | 2. BOB - Kat | 3. Cheetah | 4. Chipmunk  | 5. Luipaard ");
            Console.WriteLine("6. Leeuw     | 7. Panter    | 8. Penguin | 9. Eekhoorn  | 10. Tijger");
            int input = Convert.ToInt16(Console.ReadLine());
            string dir = Environment.CurrentDirectory + "\\sounds\\";

            switch (input)
            {
                case 1:
                    dir += "baligator.wav";
                    break;
                case 2:
                    dir += "BOB-CAT.wav";
                    break;
                case 3:
                    dir += "Cheetah4.wav";
                    break;
                case 4:
                    dir += "CHIPMUNK.wav";
                    break;
                case 5:
                    dir += "leopard7.wav";
                    break;
                case 6:
                    dir += "lion.wav";
                    break;
                case 7:
                    dir += "panther7.wav";
                    break;
                case 8:
                    dir += "penguin3.wav";
                    break;
                case 9:
                    dir += "SQMarsupflyingsquirrel2.wav";
                    break;
                case 10:
                    dir += "Tiger7.wav";
                    break;
            }

            var sp = new SoundPlayer(dir);
            sp.Play();
            Console.ReadLine();
        }
    }
}


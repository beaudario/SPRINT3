using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeclaringVariable
            IPAddress ip;

            //UserInput
            Console.Write("Geef IP-Adres: ");
            string IpAddress = Console.ReadLine();

            //DeclaringVariable
            bool IpCheck = IPAddress.TryParse(IpAddress, out ip);

            //IfStatement
            if (IpCheck)
            {
                //ShowResult
                Console.WriteLine("Dit adres bereikbaar");
            }
            else
            {
                Console.WriteLine("Dit adres is niet bereikbaar");
            }

            Console.ReadKey();
        }
    }
}

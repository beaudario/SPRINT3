using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThisYearALeapYear?
            Console.WriteLine("Zitten we nu in een schrikkeljaar: {0}", IsSchrikkeljaar());
            Console.WriteLine();

            //UserInput
            Console.Write("Geef een jaartal: ");
            int year = int.Parse(Console.ReadLine());

            if (year > 50 && year < 99)
            {
                year += 1900;
            }
            else if (year < 50)
            {
                year += 2000;
            }

            //ShowOutcome
            Console.WriteLine("Is het jaar {0} een schrikkeljaar: {1}", year, IsSchrikkeljaar(year));
            Console.WriteLine();

            //UserInput
            Console.Write("Geef een datum (bijv. 07-09-1986): ");
            string date = Console.ReadLine();
            double date1 = double.Parse(date.Substring(6));

            //ShowOutcome
            Console.WriteLine("Valt de datum {0} onder een schrikkeljaar: {1}", date, IsSchrikkeljaar(date1));
            Console.ReadKey();
        }

        //CheckingForLeapyear
        private static bool IsSchrikkeljaar(double year)
        {
            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsSchrikkeljaar(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsSchrikkeljaar()
        {
            int yearNow = int.Parse(DateTime.Now.Year.ToString());

            if (yearNow % 4 == 0)
            {
                return true;
            }

                return false;
        }
    }
}

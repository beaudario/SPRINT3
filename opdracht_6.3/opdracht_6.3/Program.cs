using System;

namespace opdracht_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer hier je datum in: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(Zodiac((date)));

        }

        //eerst maak ik een enum aan voor de sterrenbeelden
        public enum sterrenbeelden
        {
            Ram, Stier, Tweelingen, Kreeft, Leeuw, Maagd, Weegschaal, Schorpioen, Boogschutter, Steenbok, Waterman, Vissen,
        }

        //Nu moeten we de vergelijking maakenmet de maanden en datums 
        public static string Zodiac(DateTime date)
        {
             
            if (date.Month == 03 && date.Day >= 21 || date.Month == 04 && date.Day <= 20) 
            {
                return Convert.ToString(sterrenbeelden.Ram);
            }
            else if (date.Month == 04 && date.Day >= 21 || date.Month == 05 && date.Day <= 21)
            {
                return Convert.ToString(sterrenbeelden.Stier);
            }
            else if (date.Month == 05 && date.Day >= 22 || date.Month == 06 && date.Day <= 20)
            {
                return Convert.ToString(sterrenbeelden.Tweelingen);
            }
            else if (date.Month == 06 && date.Day >= 21 || date.Month == 07 && date.Day <= 22)
            {
                return Convert.ToString(sterrenbeelden.Kreeft);
            }
            else if (date.Month == 07 && date.Day >= 23 || date.Month == 08 && date.Day <= 22)
            {
                return Convert.ToString(sterrenbeelden.Leeuw);
            }
            else if (date.Month == 08 && date.Day >= 23 || date.Month == 09 && date.Day <= 22)
            {
                return Convert.ToString(sterrenbeelden.Maagd);
            }
            else if (date.Month == 09 && date.Day >= 23 || date.Month == 10 && date.Day <= 22)
            {
                return Convert.ToString(sterrenbeelden.Weegschaal);
            }
            else if (date.Month == 10 && date.Day >= 23 || date.Month == 11 && date.Day <= 22)
            {
                return Convert.ToString(sterrenbeelden.Schorpioen);
            }
            else if (date.Month == 11 && date.Day >= 23 || date.Month == 12 && date.Day <= 21)
            {
                return Convert.ToString(sterrenbeelden.Boogschutter);
            }
            else if (date.Month == 12 && date.Day >= 22 || date.Month == 01 && date.Day <= 20)
            {
                return Convert.ToString(sterrenbeelden.Steenbok);
            }
            else if (date.Month == 01 && date.Day >= 21 || date.Month == 02 && date.Day <= 19)
            {
                return Convert.ToString(sterrenbeelden.Waterman);
            }
            else if (date.Month == 02 && date.Day >= 20 || date.Month == 03 && date.Day <= 20)
            {
                return Convert.ToString(sterrenbeelden.Vissen);
            }
            return "";
        }
    }
}

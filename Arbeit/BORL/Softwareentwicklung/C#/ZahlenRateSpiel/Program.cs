using System;

namespace RateSpiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomZahl = random.Next(1, 101);

            int zaehler = 0;
            int rateZahl = 0;

            while (rateZahl != randomZahl)
            {
                Console.Write("Bitte gib eine Zahl zwischen 1 und 100 ein: ");
                rateZahl = Convert.ToInt32(Console.ReadLine());
                zaehler++;

                if (rateZahl < randomZahl)
                {
                    Console.WriteLine("\nDie eingegebene Zahl ist zu klein. Versuche es erneut.\n");
                }
                else if (rateZahl > randomZahl)
                {
                    Console.WriteLine("\nDie eingegebene Zahl ist zu groß. Versuche es erneut.\n");
                }
            }

            Console.WriteLine("Die gesuchte Zahl war {0}.", randomZahl);
            Console.WriteLine("Du hast insgesamt {0} Versuche gebraucht.", zaehler);
            Console.WriteLine("Drücke eine beliebige Taste, um das Spiel zu beenden.");
            Console.ReadKey();
        }
    }
}

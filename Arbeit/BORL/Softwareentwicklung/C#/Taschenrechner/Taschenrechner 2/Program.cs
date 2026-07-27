using System;

namespace Taschenrechner2
{
    class Program
    {
        static void Main()
        {
            char rechenoperator = ' ';
            bool pruefer = false;
            char wahl = ' ';
            Int64 zahl1 = 0;
            Int64 zahl2 = 0;

            do
            {
                Console.Write("Geben Sie die erste Zahl ein: ");
                zahl1 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Geben Sie die zweite Zahl ein: ");
                zahl2 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Geben Sie den Rechenoperator ein: ");
                do {
                    rechenoperator = Convert.ToChar(Console.ReadLine());
                    if (rechenoperator == '+')
                    {
                        pruefer = true;
                        Console.Write("Die Summe von Zahl 1 und Zahl 2 ist: {0}", zahl1 + zahl2);
                    }
                    else if (rechenoperator == '-')
                    {
                        pruefer = true;
                        if (zahl1 > zahl2)
                        {
                            Console.WriteLine("Die Differenz zwischen Zahl 1 und Zahl 2 ist: {0}", zahl1 - zahl2);
                        }
                        else if (zahl1 < zahl2)
                        {
                            Console.WriteLine("Die Differenz zwischen Zahl2 und Zahl1 ist: {0}", zahl2 - zahl1);
                        }
                        else if (zahl1 == zahl2)
                        {
                            Console.WriteLine("Die Differenz zwischen Zahl 1 und Zahl 2 ist: 0");
                        }
                    }
                    else if (rechenoperator == '*')
                    {
                        pruefer = true;
                        Console.WriteLine("Das Produkt von Zahl 1 und Zahl 2 ist: {0}", zahl1 * zahl2);
                    }
                    else if (rechenoperator == '/')
                    {
                        pruefer = true;
                        if (zahl1 <= 0 || zahl2 <= 0)
                        {
                            Console.WriteLine("Zahl kann nicht durch 0 dividiert werden");
                        }
                        else if (zahl1 > 0 && zahl2 > 0)
                        {
                            if (zahl1 > zahl2)
                            {
                                Console.WriteLine("Der Quotient von Zahl 1 und Zahl 2 ist: {0}", zahl1 / zahl2);
                            }
                            else if (zahl1 < zahl2)
                            {
                                Console.WriteLine("Der Quotient von Zahl2 durch Zahl 1 ist: {0}", zahl2 / zahl1);
                            }
                        }
                    }
                    else
                    {
                        pruefer = false;
                        Console.WriteLine("Ungültige Eingabe");
                    }
                } while (pruefer == false);
                Console.WriteLine("Möchten Sie erneut rechnen? Für Ja geben 'j' oder 'J' ein und für Nein geben Sie 'n' oder 'N'");
                wahl = Convert.ToChar(Console.ReadLine());
            }   while (wahl == 'j' || wahl == 'J');
        }
    }
}

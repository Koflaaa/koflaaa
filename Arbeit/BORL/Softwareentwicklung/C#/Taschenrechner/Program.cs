using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1 = 0;
            double zahl2 = 0;
            double erg = 0;
            string op;
            string Wahl = "";

            Console.WriteLine("Geben Sie Zahl1 ein");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie Zahl2 ein");
            zahl2 = Convert.ToDouble(Console.ReadLine());
            op = Console.ReadLine();


            do
            {
                Wahl = Console.ReadLine();
                if (op == "+")
                {
                    erg = zahl1 + zahl2;
                    Console.WriteLine(erg);
                }
                else if (op == "-")
                {
                    erg = zahl1 - zahl2;
                    Console.WriteLine(erg);
                }
                else if (op == "*")
                {
                    erg = zahl1 * zahl2;
                    Console.WriteLine(erg);

                }
                else if (op == "/")
                {
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Division durch 0 nicht möglich");
                    }
                    else
                    {
                        erg = zahl1 / zahl2;
                        Console.WriteLine(erg);
                    }
                }
                Console.WriteLine("Wiederholen? j/n");
                Console.WriteLine("Falsche Eingabe");
            } while (Wahl == "j");
        }
    }
}

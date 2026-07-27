using System;

namespace Fußball1
{
    public class Sportchef
    {
        protected string Vorname { get; set; }
        protected string Nachname { get; set; }

        public Sportchef()
        {
            Vorname = "Helmut";
            Nachname = "Schmidt";
        }

        public Sportchef(string Vorname, string Nachname)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
        }

        public class Trainer : Sportchef
        {
            public Trainer()
            {
                Vorname = "Rainer";
                Nachname = "Kalmund";
            }
        }

        public class Goali : Trainer
        {
            public Goali()
            {
                Vorname = "Karl";
                Nachname = "Nehammer";
            }
        }

        public class Feldspieler : Trainer { }

        public class Ersatzbank : Trainer { }

        class Program
        {
            static void Main()
            {
                Random random = new();
                // erstellt 2 Arrays und speichert Vor- und Nachname in diesen Arrays
                string[] Vorname = { "Guenther", "Karl", "Andi", "Andreas", "Karl", "Winston", "Josef", "Theodore", "Ronald", "Richard"};
                string[] Nachname = {"Jauch", "Nehammer", "Wand", "Babbler", "Rauch", "Churchill", "Stalin", "Roosevelt", "Reagan", "Nixon"};

                Feldspieler[] spieler1 = new Feldspieler[10];
                Ersatzbank[] bank1 = new Ersatzbank[3];

                // erstellt ein Objekt und weißt diesen Vor- und Nachname zu und gibt diese anschließend aus
                Sportchef chef1 = new Sportchef();
                Console.Write("Sportchef: \n");
                Console.WriteLine("{0} {1}\n", chef1.Vorname, chef1.Nachname);

                // erstellt ein Objekt und weißt diesen Vor- und Nachname zu und gibt diese anschließend aus
                Trainer trainer1 = new Trainer();
                Console.Write("Trainer: \n");
                Console.WriteLine("{0} {1}\n", trainer1.Vorname, trainer1.Nachname);

                // erstellt ein Objekt und weißt diesen Vor- und Nachname zu und gibt diese anschließend aus
                Goali goali1 = new Goali();
                Console.Write("Goali: \n");
                Console.WriteLine("{0} {1}\n", goali1.Vorname, goali1.Nachname);

                Console.WriteLine("Feldspieler: \n");

                for (int i = 0; i < 10; i++)
                {
                    // erstellt ein Objekt und weißt diesen Vor- und Nachname zu und gibt diese anschließend aus
                    Feldspieler feld = new Feldspieler();

                    int rnd = random.Next(Vorname.Length);
                    feld.Vorname = Vorname[rnd];
                    rnd = random.Next(Nachname.Length);
                    feld.Nachname = Nachname[rnd];

                    spieler1[i] = feld;
                    Console.WriteLine("{0} {1}\n", feld.Vorname, feld.Nachname);
                }
                Console.WriteLine();

                Console.WriteLine("Ersatzbank: \n");
                for(int i = 0; i < 3; i++)
                {
                    // erstellt ein Objekt und weißt diesen Vor- und Nachname zu und gibt diese anschließend
                    Ersatzbank ersatz = new();
                    rnd = random.Next(Vorname.Length);
                    ersatz.Vorname = Vorname[rnd];
                    rnd = random.Next(Nachname.Length);
                    ersatz.Nachname = Nachname[rnd];

                    bank1[i] = ersatz;
                    Console.WriteLine("{0} {1}\n", ersatz.Vorname, ersatz.Nachname);
                }
            }
        }
    }
}

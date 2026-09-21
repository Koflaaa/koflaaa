using System;

namespace Fußball1
{
    public class Sportchef                  // Erstellt eine Oberklasse Sportchef 
    {// mit den Attributen Vor- und Nachname
        protected string Vorname { get; set; }              
        protected string Nachname { get; set; }

        public Sportchef()
        {   // weißt den Attributen Vor- und Nachname einen string Wert zu
            Vorname = "Helmut";
            Nachname = "Schmidt";
        }

        public Sportchef(string vorname, string nachname)
        {   // anschließend wird ein Konstruktor für get; und set; erstellt der den Attributen automatisch einen Wert üerschreibt
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        public class Trainer : Sportchef
        {   // Erstellt eine Unterklasse Trainer mit den Attributen Vor- und Nachname
            public Trainer()
            {   // Weißt den Attributen per get; und set; einen neuen Wert zu
                Vorname = "Rainer";
                Nachname = "Kalmund";
            }
        }

        public class Goali : Trainer
        {   // Erstellt eine neue Unterklasse von Trainer
            public Goali()
            {   // Weißt den Attributen per get; und set; einen neuen Wert zu
                Vorname = "Karl";
                Nachname = "Nehammer";
            }
        }

        // Erstellung von 2 Arrayklassen
        public class Feldspieler : Trainer { }

        public class Ersatzbank : Trainer { }

        class Program
        {
            static void Main()
            {
                Random random = new();

                string[] vorname = { "Guenther", "Karl", "Andi", "Andreas", "Karl", "Winston", "Josef", "Theodore", "Ronald", "Richard"};
                string[] nachname = {"Jauch", "Nehammer", "Wand", "Babbler", "Rauch", "Churchill", "Stalin", "Roosevelt", "Reagan", "Nixon"};

                Feldspieler[] spieler1 = new Feldspieler[10];
                Ersatzbank[] bank1 = new Ersatzbank[3];

                Sportchef chef1 = new Sportchef();
                Console.Write("Sportchef: \n");
                Console.WriteLine("{0} {1}\n", chef1.Vorname, chef1.Nachname);

                Trainer trainer1 = new Trainer();
                Console.Write("Trainer: \n");
                Console.WriteLine("{0} {1}\n", trainer1.Vorname, trainer1.Nachname);

                Goali goali1 = new Goali();
                Console.Write("Goali: \n");
                Console.WriteLine("{0} {1}\n", goali1.Vorname, goali1.Nachname);

                Console.WriteLine("Feldspieler: \n");

                for (int i = 0; i < 10; i++)
                {
                    Feldspieler feld = new Feldspieler();

                    int rnd = random.Next(vorname.Length);
                    feld.Vorname = vorname[rnd];
                    rnd = random.Next(nachname.Length);
                    feld.Nachname = nachname[rnd];

                    spieler1[i] = feld;
                    Console.WriteLine("{0} {1}\n", feld.Vorname, feld.Nachname);
                }
                Console.WriteLine();

                Console.WriteLine("Ersatzbank: \n");
                for(int i = 0; i < 3; i++)
                {
                  Ersatzbank ersatz = new();

                  int rnd = random.Next(vorname.Length);
                  ersatz.Vorname = vorname[rnd];
                  rnd = random.Next(nachname.Length);
                  ersatz.Nachname = nachname[rnd];

                  bank1[i] = ersatz;
                  Console.WriteLine("{0} {1}\n", ersatz.Vorname, ersatz.Nachname);
                }
            }
        }
    }
}

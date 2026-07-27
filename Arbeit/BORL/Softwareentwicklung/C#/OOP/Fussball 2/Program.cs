using System;

namespace Fußball_2
{
    public class Mannschaft
    {   // erstellt eine Mannschaft mit Attributen
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        Random rnd = new();      // erstellt ein Objekt der Klasse Random

        public Mannschaft(string vorname, string nachname, int alter)
        {   // erstellt einen Konstruktor der den Variablen automatisch den Wert zuweißt
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Alter = alter;
        }

        public Mannschaft()
        {   // erstellt einen Konstruktor der durch zuweisen von z.B. Vorname = "" also leer verhinder das es ein Null Exception error gibt
            Vorname = "";
            Nachname = "";
            Alter = rnd.Next(18, 48);
            // Alter wird ein random Wert zwischen 18 und 48 zu gewiesen
        }
    }

    public class Sportchef : Mannschaft
    {   // erstellt eine Unterklasse von Mannschaft
        // erstellt eine Methode die den Sportchef vorstellt bzw. Werte in einem string Array speichert und anschließend ausgibt
        public void Namen()
        {
            Random rnd = new();

            // erstellt zwei Arrays um die Vornamen und Nachnamen die zur Wahl stehen zu speichern
            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Johannes", "Tobias", "Karl", "Albrecht" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelnmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            // weißt dem Objekt chef1 jweils einen random Vor- und Nachnamen zu
            Sportchef chef1 = new();
            int rnd = rnd.Next(vorname.Length);
            chef1.Vorname = vorname[rnd];
            rnd = rnd.Next(nachname.Length);
            chef1.Nachname = nachname[rnd];

            // Gibt den Namen und das Alter des Sportchef aus
            Console.WriteLine("Name: {0} {1} Alter: {2}", chef1.Vorname, chef1.Nachname, this.Alter);
        }
    }

    public class Trainer : Sportchef
    {   // erstellt eine Unterklasse von Sportchef

        Random rnd = new();
        // erstellt eine Variable um die Erfahrung des Trainers zu speichern
        public int Erfahrung { get; set; }

        public Trainer(int erfahrung)
        {   // erstellt einen Konstruktor der den eingegebenen Wert automatisch zurück gibt
            this.Erfahrung = erfahrung;
        }

        public Trainer()
        {   // weißt der Erfahrung einen random Wert zwischen 1 und 10 zu
            Erfahrung = rnd.Next(1, 10);
        }

        // erstellt eine Methode die den Objekt trainer1 einen random Vor- und Nachnamen zuweißt und anschließend ausgibt
        public new void Namen()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Johannes", "Tobias", "Karl", "Albrecht" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelnmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            Trainer trainer1 = new();

            int rnd = random.Next(vorname.Length);
            trainer1.Vorname = vorname[rnd];
            rnd = random.Next(nachname.Length);
            trainer1.Nachname = nachname[rnd];

            Console.WriteLine("Name: {0} {1}, Alter: {2}, Erfahrung: {3}", trainer1.Vorname, trainer1.Nachname, this.Alter, this.Erfahrung);
        }
    }

    public class Goalie : Trainer
    {   // erstellt eine Unterklasse von Trainer
        Random rnd = new();

        public int ReaktVermögen { get; set; }
        public int Spielstärke { get; set; }
        public int Motivation { get; set; }

        public Goalie(int reaktVermögen, int spielstärke, int motivation)
        {
            this.ReaktVermögen = reaktVermögen;
            this.Spielstärke = spielstärke;
            this.Motivation = motivation;
        }

        public Goalie()
        {   // weißt den Variablen einen random Wert zwischen 1 und 10 zu
            ReaktVermögen = random.Next(1, 10);
            Spielstärke = random.Next(1, 10);
        }

        public new void Namen()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Johannes", "Tobias", "Karl", "Albrecht" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelnmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            Goalie goalie1 = new();

            int rnd = random.Next(vorname.Length);
            goalie1.Vorname = vorname[rnd];
            rnd = random.Next(nachname.Length);
            goalie1.Nachname = nachname[rnd];
            rnd = random.Next(1, 10);
            goalie1.Motivation = rnd;

            Console.WriteLine("Name: {0} {1}, Alter: {2}, Motivation: {3}, Spielstärke: {4}, Reaktionsvermögen: {5}", goalie1.Vorname, goalie1.Nachname, goalie1.Alter, goalie1.Motivation, goalie1.Spielstärke, goalie1.ReaktVermögen);
        }
    }

    public class Feldspieler : Trainer
    {
        public int Spielstärke { get; set; }
        public int Torschussqualität { get; set; }
        public int Motivation { get; set; }
        public int Tore { get; set; }

        public Feldspieler(int spielstärke, int torschussqualität, int motivation, int tore)
        {
            this.Torschussqualität = torschussqualität;
            this.Spielstärke = spielstärke;
            this.Motivation = motivation;
            this.Tore = tore;
        }

        public Feldspieler()
        {
            Tore = 0;
        }

        public new void Namen()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Max", "Tobias", "Karl", "Alexander" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelnmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            Feldspieler spieler1 = new();

            int rnd = random.Next(vorname.Length);
            spieler1.Vorname = vorname[rnd];
            rnd = random.Next(nachname.Length);
            spieler1.Nachname = nachname[rnd];
            rnd = random.Next(1, 10);
            spieler1.Spielstärke = rnd;
            rnd = random.Next(1, 10);
            spieler1.Motivation = rnd;
            rnd = random.Next(1, 10);
            spieler1.Torschussqualität = rnd;

            Console.WriteLine("Name: {0} {1}, Alter: {2}, Spielstärke: {3}, Torschussqualität: {4}, Motivation: {5}", spieler1.Vorname, spieler1.Nachname, spieler1.Alter, spieler1.Motivation, spieler1.Spielstärke, spieler1.Motivation);
            Console.WriteLine();
        }
    }

    public class Ersatzbank : Trainer
    {
        public int spielstärke;
        public int motivation;
        public int torschussqualität;
        public int tore;


        public Ersatzbank(int spielstärke, int torschussqualität, int motivation, int tore)
        {
            this.spielstärke = spielstärke;
            this.motivation = motivation;
            this.torschussqualität = torschussqualität;
            this.tore = tore;
        }

        public Ersatzbank()
        {
            tore = 0;
        }

        public new void Namen()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Max", "Tobias", "Karl", "Alexander" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelnmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            Ersatzbank bank1 = new();

            int rnd = random.Next(vorname.Length);
            bank1.Vorname = vorname[rnd];
            rnd = random.Next(nachname.Length);
            bank1.Nachname = nachname[rnd];
            rnd = random.Next(1, 10);
            bank1.spielstärke = rnd;
            rnd = random.Next(1, 10);
            bank1.motivation = rnd;
            rnd = random.Next(1, 10);
            bank1.torschussqualität = rnd;

            Console.WriteLine("Name: {0} {1}, Alter: {2}, Spielstärke: {3}, Toschussqualität: {4}, Motivation: {5}", bank1.Vorname, bank1.Nachname, bank1.Alter, bank1.spielstärke, bank1.torschussqualität, bank1.motivation);
        }
    }

    class Program
    {
        static void Main()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Max", "Tobias", "Karl", "Alexander" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelmus", "Knuspermann", "Stocklbua", "Niehammer", "van den Wellen" };

            // erstellt Variablen um die Stärke der Mannschaften, die Motivation der Mannschaften, Trainer und die Gesammtstärken speichert
            double m1Stärke = 0;
            double m2Stärke = 0;
            double m1Motivation = 0;
            double m2Motivation = 0;
            double m1Trainer = 0;
            double m2Trainer = 0;
            double gesammtStärke = 0;
            double gesammtStärke2 = 0;

            // Objekte der Klasse für Mannschaft 1
            Mannschaft mannschaft1 = new();
            Sportchef chef1 = new();
            Trainer trainer1 = new();
            Goalie goalie1 = new();
            Feldspieler spieler1 = new();
            Ersatzbank bank1 = new();

            // markiert den Start der Mannschaft 1
            Console.WriteLine("Mannschaft 1");

            // Stellt den Sportchef der Mannschaft 1 vor
            Console.Write("Sportchef:\n");
            chef1.Namen();
            Console.WriteLine();

            // stellt den Trainer der Mannschaft 1 vor
            Console.WriteLine("Trainer:\n");
            trainer1.Namen();
            Console.WriteLine();

            // stellt den Goalie der Mannschaft 1 vor
            Console.WriteLine("Goalie:\n");
            goalie1.Namen();
            Console.WriteLine();

            //  stellt die Feldspieler der Mannschaft 1 vor mit der Motivation und der Stärke
            Console.WriteLine("Feldspieler:\n");
            for (int i = 0; i < 10; i++)
            {
                spieler1.Namen();

                m1Stärke += spieler1.Spielstärke;
                m1Motivation += spieler1.Motivation;
            }
            Console.WriteLine();

            // stellt die Wechselspieler von Mannschaft 1 vor
            Console.WriteLine("Ersatzbank: \n");
            for (int i = 0; i < 3; i++)
            {
                bank1.Namen();
            }
            Console.WriteLine();

            // gibt die Gesammtstärke der Mannschaft aus
            Console.Write("Gesammt Stärke: ");

            m1Stärke += goalie1.Spielstärke;
            m1Stärke /= 11;
            m1Stärke *= 0.8;

            m1Motivation += goalie1.Motivation;
            m1Motivation /= 11;
            m1Motivation *= 0.15;

            m1Trainer *= 0.05;

            gesammtStärke = m1Stärke + m1Motivation + m1Trainer;
            Console.WriteLine(gesammtStärke);

            // Erstellt Objekte für Mannschaft 2
            Mannschaft mannschaft2 = new();
            Sportchef chef2 = new();
            Trainer trainer2 = new();
            Goalie goalie2 = new();
            Feldspieler spieler2 = new();
            Ersatzbank bank2 = new();

            // markiert den Start der Mannschaft 2
            Console.WriteLine("Mannschaft 2");

            // stellt den Sporchef von Mannschaft 2 vor
            Console.WriteLine("Sportchef 2: \n");
            chef2.Namen();
            Console.WriteLine();

            //  stellt den Trainer von Mannschaft 2 vor
            Console.WriteLine("Trainer 2: \n");
            trainer2.Namen();
            Console.WriteLine();

            //  stellt den Goalie von Mannschaft 2 vor
            Console.WriteLine("Goalie 2: \n");
            goalie2.Namen();
            Console.WriteLine();

            //  stellt die Feldspieler und die Motivation und Stärke von Mannschaft 2 vor
            Console.WriteLine("Feldspieler 2: \n");
            for (int i = 0; i < 10; i++)
            {
                spieler2.Namen();

                m2Stärke += spieler2.Spielstärke;
                m2Motivation += spieler2.Motivation;
            }

            // stellt die Wechselspieler von Mannschaft 2 vor
            Console.WriteLine("Ersatzbank 2:\n");
            for (int i = 0; i < 3; i++)
            {
                bank2.Namen();
            }

            // gibt die Gesammtstärke von Mannschaft 2 aus
            Console.Write("Gesammt Stärke 2: ");
            m2Stärke += goalie2.Spielstärke;
            m2Stärke /= 11;
            m2Stärke *= 0.8;

            m2Motivation += goalie2.Motivation;
            m2Motivation /= 11;
            m2Motivation *= 0.15;

            m2Trainer *= 0.05;

            gesammtStärke2 = m2Stärke + m2Motivation + m2Trainer;

            Console.WriteLine(gesammtStärke2);
            Console.WriteLine();

            // gibt nochmals die Gesammtstärken von den Mannschaften aus
            Console.WriteLine("Gesammt Stärke aller Mannschaften:\n");
            Console.WriteLine("Mannschaft 1: {0}\n", gesammtStärke);
            Console.WriteLine("Mannschaft 2: {0}\n", gesammtStärke2);


            // Überprüft ob die gesammtStärke größer als die gesammtStärke
            // Wenn ja hat Mannschaft 1 gewonnen
            // wenn nicht hat Mannschaft 2 gewonnen
            // sollte keine Bedingung zutreffen wird eine Error-Message ausgegeben
            if (gesammtStärke > gesammtStärke2)
            {
                Console.WriteLine("Mannschaft 1 hat gewonnen!");
            }
            else if (gesammtStärke < gesammtStärke2)
            {
                Console.WriteLine("Mannschaft 2 hat gewonnen!");
            }
            else
            {
                Console.WriteLine("Unentschieden.");
            }

            Console.ReadLine();
        }
    }
}

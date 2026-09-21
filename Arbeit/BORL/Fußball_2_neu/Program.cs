using System;

namespace Fußball_2
{
    public class Mannschaft
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        protected Random rnd = new();

        public Mannschaft(string vorname, string nachname, int alter)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Alter = alter;
        }

        public Mannschaft()
        {
            Vorname = "";
            Nachname = "";
            Alter = rnd.Next(18, 52);
        }

        public virtual void Namen()
        {
            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Tobias", "Max", "Alexander" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelmus", "Knuspermann", "Stocklbua", "Niehammer", "van der Wellen" };

            int random = rnd.Next(vorname.Length);
            this.Vorname = vorname[random];
            random = rnd.Next(nachname.Length);
            this.Nachname = nachname[random];

            Console.WriteLine("Name: {0} {1}, Alter: {2}", this.Vorname, this.Nachname, this.Alter);
        }
    }

    public class Sportchef : Mannschaft
    {
        public new virtual void Namen()
        {
            base.Namen(); // Aufruf der Funktion in der Oberklasse
        }
    }

    public class Trainer : Sportchef
    {
        public int Erfahrung { get; set; }

        public Trainer(int erfahrung)
        {
            this.Erfahrung = erfahrung;
        }

        public Trainer()
        {
            Erfahrung = rnd.Next(1, 10);
        }

        public override void Namen()
        {
            base.Namen(); // Aufruf der Funktion in der Oberklasse

            Console.WriteLine(", Erfahrung: {0}", this.Erfahrung);
        }
    }

    public class Goalie : Trainer
    {
        public int ReaktVermögen { get; set; }
        public int Spielstärke { get; set; }
        public int Motivation { get; set; }

        public Goalie(int reaktVermögen, int spielStärke, int motivation)
        {
            this.ReaktVermögen = reaktVermögen;
            this.Spielstärke = spielStärke;
            this.Motivation = motivation;
        }

        public Goalie()
        {
            ReaktVermögen = rnd.Next(1, 20);
            Spielstärke = rnd.Next(1, 10);
        }

        public override void Namen()
        {
            base.Namen(); // Aufruf der Funktion in der Oberklasse

            Console.WriteLine(", Motivation: {0}, Spielstärke: {1}, Reaktionsvermögen: {2}", this.Motivation, this.Spielstärke, this.ReaktVermögen);
        }
    }

    public class Feldspieler : Trainer
    {
        public int Spielstärke { get; set; }
        public int Torschussqualität { get; set; }
        public int Motivation { get; set; }
        public int Tore { get; set; }

        public Feldspieler(int spielStärke, int torschussQualität, int motivation, int tore)
        {
            this.Spielstärke = spielStärke;
            this.Torschussqualität = torschussQualität;
            this.Motivation = motivation;
            this.Tore = tore;
        }

        public Feldspieler()
        {
            Tore = 0;
        }

        public override void Namen()
        {
            base.Namen(); // Aufruf der Funktion in der Oberklasse

            Console.WriteLine(", Spielstärke: {0}, Torschussqualität: {1}, Motivation: {2}", this.Spielstärke, this.Torschussqualität, this.Motivation);
        }
    }

    public class Ersatzbank : Trainer
    {
        public int Spielstärke { get; set; }
        public int Motivation { get; set; }
        public int Torschussqualität { get; set; }
        public int Tore { get; set; }

        public Ersatzbank(int spielStärke, int torschussQualität, int motivation, int tore)
        {
            this.Spielstärke = spielStärke;
            this.Motivation = motivation;
            this.Torschussqualität = torschussQualität;
            this.Tore = tore;
        }

        public Ersatzbank()
        {
            Tore = 0;
        }

        public override void Namen()
        {
            base.Namen(); // Aufruf der Funktion in der Oberklasse

            Console.WriteLine(", Spielstärke: {0}, Torschussqualität: {1}, Motivation: {2}", this.Spielstärke, this.Torschussqualität, this.Motivation);
        }
    }

    class Program
    {
        static void Main()
        {
            Random rnd = new();

            string[] vorname = { "Holga", "Olaf", "Peter", "Josef", "Günther", "Helmut", "Max", "Tobias", "Karl", "Alexander" };
            string[] nachname = { "Wenzelhaus", "Bubennuss", "Ausdielaus", "Staddltaler", "Knuspernikus", "Dattelmus", "Knuspermann", "Stocklbua", "Niehammer" };
            double m1Stärke = 0;
            double m2Stärke = 0;
            double m1Motivation = 0;
            double m2Motivation = 0;
            double m1Trainer = 0;
            double m2Trainer = 0;
            double gesammtStärke = 0;
            double gesammtStärke2 = 0;

            Mannschaft mannschaft1 = new();
            Sportchef chef1 = new();
            Trainer trainer1 = new();
            Goalie goalie1 = new();
            Feldspieler spieler1 = new();
            Ersatzbank bank1 = new();

            Console.WriteLine("Mannschaft 1:\n");

            Console.WriteLine("Sportchef:\n");
            chef1.Namen();
            Console.WriteLine();


            Console.WriteLine("\nTrainer:");
            trainer1.Namen();
            Console.WriteLine();


            Console.WriteLine("\nGoalie:");
            goalie1.Namen();
            Console.WriteLine();

            Console.WriteLine("\nFeldspieler:");
            for (int i = 0; i < 10; i++)
            {
                spieler1.Namen();

                m1Stärke = spieler1.Spielstärke;
                m1Motivation += spieler1.Motivation;
            }
            Console.WriteLine();

            Console.WriteLine("\nErsatzbank:");
            for (int i = 0; i < 3; i++)
            {
                bank1.Namen();
            }
            Console.WriteLine();

            Console.WriteLine("Gesammt Stärke:");

            m1Stärke += goalie1.Spielstärke;
            m1Stärke /= 11;
            m1Stärke *= 0.8;

            m1Motivation += goalie1.Motivation;
            m1Motivation /= 11;
            m1Motivation *= 0.15;

            m1Trainer += 0.05;

            gesammtStärke = m1Stärke + m1Motivation + m1Trainer;
            Console.WriteLine("Gesammt Stärke Mannschaft 1: {0:F3}", gesammtStärke);


            Mannschaft mannschaft2 = new();
            Sportchef chef2 = new();
            Trainer trainer2 = new();
            Goalie goalie2 = new();
            Feldspieler spieler2 = new();
            Ersatzbank bank2 = new();

            Console.WriteLine("Mannschaft 2:\n");
            Console.WriteLine("Sportchef 2:\n");
            chef2.Namen();
            Console.WriteLine();

            Console.WriteLine("Trainer 2:\n");
            trainer2.Namen();
            Console.WriteLine();

            Console.WriteLine("Goalie 2:\n");
            goalie2.Namen();
            Console.WriteLine();

            Console.WriteLine("Feldspieler 2:\n");
            for (int i = 0; i < 10; i++)
            {
                spieler2.Namen();

                m2Stärke += spieler2.Spielstärke;
                m2Motivation += spieler2.Motivation;
            }
            Console.WriteLine();

            Console.WriteLine("Ersatzbank");
            for (int i = 0; i < 3; i++)
            {
                bank2.Namen();
            }
            Console.WriteLine();

            Console.WriteLine("Gesammt Stärke 2:\n");
            m2Stärke += goalie2.Spielstärke;
            m2Stärke /= 11;
            m2Stärke *= 0.8;

            m2Motivation += goalie2.Motivation;
            m2Motivation /= 11;
            m2Motivation *= 0.15;

            m2Trainer *= 0.05;

            gesammtStärke2 = m2Stärke + m2Motivation + m2Trainer;

            Console.WriteLine("Gesammt Stärke Mannschaft 2: {0:F3}", gesammtStärke2);
            Console.WriteLine();

            Console.WriteLine("Gesammt Stärke aller Mannschaften:\n");
            Console.WriteLine("Mannschaften 1: {0:F3}\n", gesammtStärke);
            Console.WriteLine("Mannschaft 2:{0:F3}\n", gesammtStärke2);

            if (gesammtStärke < gesammtStärke2)
            {
                Console.WriteLine("Mannschaft 2 hat gewonnen!");
            }
            else if (gesammtStärke2 < gesammtStärke)
            {
                Console.WriteLine("Mannschaft 1 hat gewonnen!");
            }
            else
            {
                Console.WriteLine("Unentschieden!");
            }
            Console.ReadLine();
        }
    }
}

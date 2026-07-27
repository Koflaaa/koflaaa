using System;

namespace übungsAufgabe_oop
{
    public class Fahrzeug
    {
        public int Preis;

        public virtual void SichBewegen()
        {
            Console.WriteLine("Fahrzeug bewegt sich.");
        }
        public virtual void Starten()
        {
            Console.WriteLine("Das Fahrzeug startet.");
        }
        public virtual void Stoppen()
        {
            Console.WriteLine("Das Fahrzeug stoppt.");
        }
    }

    public class PKW : Fahrzeug
    {
        public string Marke;
        public int anzahlSitzplaetze;

        public override void SichBewegen()
        {
            Console.WriteLine("Der PKW bewegt sich vorwärts.");
        }
        public override void Starten()
        {
            Console.WriteLine("Der PKW startet den Motor.");
        }
        public override void Stoppen()
        {
            Console.WriteLine("Der PKW stoppt den Motor.");
        }
        public static void Beschleunigen()
        {
            Console.WriteLine("Der PKW beschleunigt rapide.");
        }
        public static void Bremsen()
        {
            Console.WriteLine("Der PKW bremst ab.");
        }
    }
    public class Flugzeug : Fahrzeug
    {
        public string Marke;
        public int anzahlSitzplaetze;

        public override void SichBewegen()
        {
            Console.WriteLine("Das Flugzeug fliegt.");
        }
        public override void Starten()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
        public override void Stoppen()
        {
            Console.WriteLine("Das Flugzeug stoppt.");
        }
        public static void Beschleunigen()
        {
            Console.WriteLine("Das Flugzeug beschleunigt schnell.");
        }
        public static void Bremsen()
        {
            Console.WriteLine("Das Flugzeug bremst rapide ab.");
        }
    }

    class Program
    {
        static void Main()
        {
            PKW pkw1 = new();
            pkw1.Marke = "Mercedes";
            pkw1.anzahlSitzplaetze = 5;

            Flugzeug flugzeug1 = new();
            flugzeug1.Marke = "Airbus";
            flugzeug1.anzahlSitzplaetze = 380;

            pkw1.Starten();
            PKW.Beschleunigen();
            pkw1.SichBewegen();
            PKW.Bremsen();
            pkw1.Stoppen();

            Console.WriteLine();

            flugzeug1.Starten();
            Flugzeug.Beschleunigen();
            flugzeug1.SichBewegen();
            Flugzeug.Bremsen();
            flugzeug1.Stoppen();


            Console.WriteLine($"\nPKW 1 Marke: {pkw1.Marke}, Anzahl der Sitzplaetze: {pkw1.anzahlSitzplaetze}\n");
            Console.WriteLine($"Flugzeug 1 Marke: {flugzeug1.Marke}, Anzahl der Sitzplaetze: {flugzeug1.anzahlSitzplaetze}\n");
        }
    }
}

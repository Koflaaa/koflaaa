using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Fußball_3
{
    public class Mannschaft  // Erstellen einer Oberklasse mit dem Namen Mannschaft
    {
		// get = gibt den Wert einer Variable zurück
		// set = übergibt einer Variable einen Wert
        public string Name { get; set; }
        public int Alter { get; set; }

        Random rnd = new();
        public Mannschaft(string Name, int Alter)
        {
            this.Name = Name;
            this.Alter = Alter;
        }
        public Mannschaft()
        {
            Name = " ";
            Alter = rnd.Next(18, 48);
        }
    }
    public class gewählterSpieler : Mannschaft
    {//	erstellt eine neue Unterklasse die die Variablen von Mannschaft (Name und Alter) übernimmt und neue Variablen erstellt
        public int Spielstärke { get; set; }
        public int Torschussqualität { get; set; }
        public int Motivation { get; set; }
        public int Nummer { get; set; }

        public gewählterSpieler(int Spielstärke, int Torschussqualität, int Motivation, int tore, int Nummer)
        {
            this.Spielstärke = Spielstärke;
            this.Torschussqualität = Torschussqualität;
            this.Motivation = Motivation;
            this.Nummer = Nummer;
        }
        public gewählterSpieler()
        { }
        public void Vorstellen()
        {//	Erstellt eine Methode die die Feldspieler vorstellen soll: Name, Alter, Torschussqualität und dessen Nummer
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Alter: {0}", Alter);
            Console.WriteLine("Torschussqualität {0}", Torschussqualität);
            Console.WriteLine("Nummer {0}\n", Nummer);
        }
    }
    public class Goali : Mannschaft
    {//	erstellt eine neue Unterklasse von Mannschaft
	
        Random rnd = new Random();
        public int reaktVermögen { get; set; }
        public int Spielstärke { get; set; }
        public int Motivation { get; set; }

        public Goali(int reaktVermögen, int Spielstärke, int Motivation)
        {
            this.reaktVermögen = reaktVermögen;
            this.Spielstärke = Spielstärke;
            this.Motivation = Motivation;
        }
        public Goali()
        {
            reaktVermögen = rnd.Next(1, 10);
            Spielstärke = rnd.Next(1, 10);
            Motivation = rnd.Next(1, 10);
        }

        public void Vorstellen()        //Vorstellenmethode Torwart
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Alter: {0}", Alter);
            Console.WriteLine("Spielstärke {0}", Spielstärke);
            Console.WriteLine("Readktionsvermögen {0}", reaktVermögen);
			Console.WriteLine("Motivation: {0}\n", Motivation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int schieß = 0;
            int gewählterSpieler = 0;
            int gewählterSpielerStärke = 0;
            int twStärke1 = 0;
            int twStärke2 = 0;
            int varianz = rnd.Next(-2, 1);

            Mannschaft Mannschaft = new Mannschaft();
            Goali Goali = new Goali();
            gewählterSpieler spieler = new gewählterSpieler();

            Console.WriteLine("Mannschaft");

            Console.WriteLine("Goali");
            Goali.Name = "Klaus Kinski:";
            Goali.Vorstellen();
            Console.WriteLine();

            Console.WriteLine("gewählterSpieler:");
            Console.WriteLine();
            gewählterSpieler[] Namen = new gewählterSpieler[10];

			// Die Daten von den Spieler (Name, Alter, Torschussqualität und Nummer) werden in einem Array (Namen) gespeichert
            Namen[0] = new gewählterSpieler { Name = "Angela Merkel", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 1 };
            Namen[1] = new gewählterSpieler { Name = "Dennis Brammen", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 2 };
            Namen[2] = new gewählterSpieler { Name = "Peter Smits", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 3 };
            Namen[3] = new gewählterSpieler { Name = "Jonnatan William Appelt", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 4 };
            Namen[4] = new gewählterSpieler { Name = "Hans-Peter Schmidt", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 5 };
            Namen[5] = new gewählterSpieler { Name = "Donald Trump", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 6 };
            Namen[6] = new gewählterSpieler { Name = "Micheal Mayers", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 7 };
            Namen[7] = new gewählterSpieler { Name = "Pablo Escobar", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 8 };
            Namen[8] = new gewählterSpieler { Name = "Sebastian Lensen", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 9 };
            Namen[9] = new gewählterSpieler { Name = "Christian Stachelhaus", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 10 };
			
			// Die Daten werden in einer for-Schleife ausgegeben, anstatt 10 Zeilen werden nur 3-4 Zeilen benötigt.
			for (int i = 0; i < 10; i++)
			{
			Namen[i].Vorstellen();
			}
          /*Namen[0].Vorstellen();
            Namen[1].Vorstellen();
            Namen[2].Vorstellen();
            Namen[3].Vorstellen();
            Namen[4].Vorstellen();
            Namen[5].Vorstellen();
            Namen[6].Vorstellen();
            Namen[7].Vorstellen();
            Namen[8].Vorstellen();
            Namen[9].Vorstellen();*/

            Mannschaft mannschaft2 = new Mannschaft();
            Goali Goali2 = new Goali();
            gewählterSpieler spieler2 = new gewählterSpieler();


            Console.WriteLine("Mannschaft 2");
            Console.WriteLine();

            Console.WriteLine("Goali 2:");
            Goali2.Name = "Gerhard Schröder";
            Goali2.Vorstellen();
            Console.WriteLine();

            Console.WriteLine("Spieler 2:");
            Console.WriteLine();
            gewählterSpieler[] Namen2 = new gewählterSpieler[10];

			// Die Daten von den Spieler (Name, Alter, Torschussqualität und Nummer) werden in einem Array (Namen2) gespeichert
            Namen2[0] = new gewählterSpieler { Name = "Karl Nehammer", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 1 };
            Namen2[1] = new gewählterSpieler { Name = "Sebastian Kurz", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 2 };
            Namen2[2] = new gewählterSpieler { Name = "Alexander van der Bellen", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 3 };
            Namen2[3] = new gewählterSpieler { Name = "Nicolai Tesla", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 4 };
            Namen2[4] = new gewählterSpieler { Name = "Alessandro Volta", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 5 };
            Namen2[5] = new gewählterSpieler { Name = "Josef Stalinski", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 6 };
            Namen2[6] = new gewählterSpieler { Name = "Göhring Eghard", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 7 };
            Namen2[7] = new gewählterSpieler { Name = "Helmut Schmidt", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 8 };
            Namen2[8] = new gewählterSpieler { Name = "Dagobert Duck", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 9 };
            Namen2[9] = new gewählterSpieler { Name = "Helmut Kohl", Alter = rnd.Next(18, 48), Torschussqualität = rnd.Next(1, 10), Nummer = 10 };
			
			// Die Daten von den Spieler (Name, Alter, Torschussqualität und Nummer) werden in einem Array (Namen) gespeichert
			for (int i=0; i<10:i++)
			{
				Namen2[i].Vorstellen();
			}
          /*Namen2[0].Vorstellen();
            Namen2[1].Vorstellen();
            Namen2[2].Vorstellen();
            Namen2[3].Vorstellen();
            Namen2[4].Vorstellen();
            Namen2[5].Vorstellen();
            Namen2[6].Vorstellen();
            Namen2[7].Vorstellen();
            Namen2[8].Vorstellen();
            Namen2[9].Vorstellen();*/

			//Torwartstärke für beide Mannschaften ausgerechnet
            twStärke1 = Goali.reaktVermögen + varianz;
            twStärke2 = Goali2.reaktVermögen + varianz;
            
            Console.WriteLine("Wähle deine Mannschaft die schießen soll");
            schieß = Convert.ToInt32(Console.ReadLine());
			// Überprüft ob schieß 1 oder 2 ist wenn nicht wird ein Error ausgegeben
            if (schieß == 1)
            {
                Console.WriteLine("\nWähle einen Spieler aus Mannschaft 1 aus");
                gewählterSpieler = Convert.ToInt32(Console.ReadLine());
				
					/*Überprüft die Eingabe ob die Eingabe größer oder gleich 1 ist und kleiner oder gleich 10 ist
					falls die Eingabe kleiner als 1 und größer als 10 ist wird eine Error Nachricht ausgegeben
					wenn nicht wird die Spielerstärke und die Torwartstärke berechnet und anschließend ausgegeben
					Anschließend wird überprüft ob Mannschaft 1 stärker ist oder ob Mannschaft 2 stärker ist und anschließend wird der stärkere als gewinner ausgegeben*/
                if (gewählterSpieler >= 1 && gewählterSpieler <= 10)
                {
                    gewählterSpieler wahlgewählterSpieler = Namen[gewählterSpieler - 1];
                    wahlgewählterSpieler.Vorstellen();
                    Console.WriteLine();

                    gewählterSpielerStärke = wahlgewählterSpieler.Torschussqualität + varianz;

                    Console.WriteLine("Schussqualität gewählterSpieler " + gewählterSpieler + ": " + gewählterSpielerStärke);
                    Console.WriteLine("Torwartstärke: " + twStärke2);

                    if (gewählterSpielerStärke > twStärke2)
                    {
                        Console.WriteLine("Mannschaft hat gewonnen!");
                    }
                    else Console.WriteLine("Mannschaft2 hat gewonnen!");
                }
                else
                {
                    Console.WriteLine("Keine gültige Eingabe!");
                }
            }
            else if (schieß == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Wähle einen Spieler aus Mannschaft 2 aus");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}. Spieler = {1}", i + 1, spieler.Name[i]);
                }
                gewählterSpieler = Convert.ToInt32(Console.ReadLine());

                if (gewählterSpieler >= 1 && gewählterSpieler <= 10)
                {
                    gewählterSpieler wahlgewählterSpieler = Namen2[gewählterSpieler - 1];
                    wahlgewählterSpieler.Vorstellen();
                    Console.WriteLine();

                    gewählterSpielerStärke = wahlgewählterSpieler.Torschussqualität + varianz;

                    Console.WriteLine("Schussqualität gewählterSpieler " + gewählterSpieler + ": " + gewählterSpielerStärke);
                    Console.WriteLine("Torwartstärke: " + twStärke1);

                    if (gewählterSpielerStärke > twStärke1)
                    {
                        Console.WriteLine("Mannschaft 2 hat gewonnen!");
                    }
                    else Console.WriteLine("Mannschaft 1 hat gewonnen!");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }
            Console.ReadLine();
        }
    }
}
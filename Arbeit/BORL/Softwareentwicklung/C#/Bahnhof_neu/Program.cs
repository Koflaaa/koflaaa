using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahnhof
{
    public class Bahnhof
    {
        public int AnzahlZuege { get; set; }
        public int AnzahlWagen { get; set; }
        public string Ziele { get; set; }                  // Bahnhof Attribute
        public int WagAnzahl { get; set; }

        public Bahnhof(int AnzahlZuege, int AnzahlWagen, string Ziele)
		
        {
            this.AnzahlZuege = AnzahlZuege;
            this.AnzahlWagen = AnzahlWagen;
            this.Ziele = Ziele;
        }

        public Bahnhof()
        {
            Ziele = string.Empty;
        }

        public int WagenZahl()
        {
            return AnzahlWagen;              //gibt die Anzahl der Wagen zurück
        }

        public int ZugZahl()
        {
            return AnzahlZuege;              //gibt die Anzahl der Züge zurück
        }

        public void AddZug(Zug zug)
        {
            AnzahlZuege += 1; 	            //anzahl der züge im bahnhof
            AnzahlWagen += zug.WagenAnzahl();
            Ziele = zug.Ziel;
        }

        public void AddSteig(Bahnsteig b)
        {
            WagAnzahl += b.WZahl();                //anzahl der wagen im bahnhof
        }

    }
    public class Bahnsteig
    {
        public string Zielname { get; set; }
        public int WagAnzahl { get; set; }                  //bahnsteigattribute
        public int ZAnzahl { get; set; }

        public Bahnsteig(string Zielname, int WagAnzahl, int ZAnzahl)
        {
            this.Zielname = Zielname;
            this.WagAnzahl = WagAnzahl;
            this.ZAnzahl = ZAnzahl;
        }

        public Bahnsteig()
        {
            Zielname = "";
            ZAnzahl = 0;
        }

        public int WZahl()
        {
            return WagAnzahl;   //gibt die Anzahl der Wagen zurück
        }
    }
    public class Zug
    {
        public string Ziel { get; set; }
        public int AnzahlWagen { get; set; }

        public int WagenAnzahl()
        {
            return AnzahlWagen;               //gibt die anzahl der wagen zurück
        }
    }
    class Program
    {
        static void Main()
        {
            // erstellt objekte für die Klasse Zug
            Zug zug1 = new();
            Zug zug2 = new();
            Zug zug3 = new();
            Zug zug4 = new();

            // erstellt bahnsteig und bahnhof objekte
            Bahnsteig steig1 = new();
            Bahnsteig steig2 = new();
            Bahnsteig steig3 = new();
            Bahnhof bahnhof1 = new();

            // --> weißt den Zügen eine Anzahl an Wagons zu
            zug1.AnzahlWagen = 8;
            zug2.AnzahlWagen = 6;
            zug3.AnzahlWagen = 10;
            zug4.AnzahlWagen = 12;

            // weißt den Zügen ein Ziel zu
            zug1.Ziel = "Bern";
            zug2.Ziel = "Paris";
            zug3.Ziel = "Rom";
            zug4.Ziel = "Wien";

            // weißt den Wagons Anzahl an den Bahnsteigen die Anzahl der Wagons der Züge zu
            steig1.WagAnzahl = zug4.AnzahlWagen;
            steig2.WagAnzahl = zug3.AnzahlWagen;
            steig3.WagAnzahl = zug1.AnzahlWagen + zug2.AnzahlWagen;

            // addiert die züge zum Bahnhofsobjekt bzw. weißt den Zügen den Bahnhof zu plus den Bahnsteigen
            bahnhof1.AddZug(zug1);
            bahnhof1.AddZug(zug2);
            bahnhof1.AddZug(zug3);
            bahnhof1.AddZug(zug4);
            bahnhof1.AddSteig(steig1);
            bahnhof1.AddSteig(steig2);
            bahnhof1.AddSteig(steig3);

            // Gibt die Ziele von den Zügen aus
            Console.WriteLine("Ziele für Bahnhof");
            Console.Write("Ziel 1: " + zug1.Ziel + "\n" + "Ziel 2: " + zug2.Ziel + "\n" + "Ziel 3: " + zug3.Ziel + "\n" + "Ziel 4: " + zug4.Ziel + "\n");       //Ziele
            Console.WriteLine();

            // Gibt die Anzahl der Züge am Bahnhof aus
            Console.WriteLine("Anzahl der Züge die sich am Bahnhof befinden:" + "\n" + bahnhof1.ZugZahl() + "\n");     //Zuganzahl am Bahnhof

            // gibt die Anzahl der Züge an den Bahnsteigen aus
            Console.WriteLine("Anzahl der Wagen an Bahnsteigen:");
            Console.WriteLine("Bahnsteig 1: " + steig1.WZahl() + "\n" + "Bahnsteig 2: " + steig2.WZahl() + "\n" + "Bahnsteig 3: " + steig3.WZahl());        //Wagenanzahl an jedem Bahnsteig
            Console.WriteLine();

            // Gibt die Anzahl der Wagons aus die sich am Bahnhof befinden
            Console.WriteLine("Anzahl der Wagen die sich am Bahnhof befinden:" + "\n" + bahnhof1.WagenZahl());      //Wagenanzahl am Bahnhof

            // Gibt den gesammten Fahrplan von den Zügen aus
            Console.WriteLine("Fahrplan:\n");
            Console.WriteLine("Zug 1 mit {0} Wagons fährt nach {1}.\n", zug1.WagenAnzahl(), zug1.Ziel);
            Console.WriteLine("Zug 2 mit {0} Wagons fährt nach {1}.\n", zug2.WagenAnzahl(), zug2.Ziel);
            Console.WriteLine("Zug 3 mit {0} Wagons fährt nach {1}.\n", zug3.WagenAnzahl(), zug3.Ziel);
            Console.WriteLine("Zug 4 mit {0} Wagons fährt nach {1}.\n", zug4.WagenAnzahl(), zug4.Ziel);

            Console.ReadLine();

        }
    }
}

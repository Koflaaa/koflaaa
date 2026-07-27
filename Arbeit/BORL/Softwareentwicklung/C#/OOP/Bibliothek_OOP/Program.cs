using System;
using System.Collections.Generic;
using System.IO;

namespace Bibliothek_OOP
{
    internal class Program
    {
        private class Bibliothek
        {
            // Liste, um alle Buch-Objekte zu speichern
            public List<Buch> Buecher { get; private set; }

            // Konstruktor, initialisiert die Buchliste
            public Bibliothek()
            {
                Buecher = new List<Buch>();
            }

            // Fügt ein Buch zur Liste hinzu und speichert die Bibliothek
            public void BuchHinzufuegen(Buch buch, string dateipfad)
            {
                Buecher.Add(buch); // Buch zur Liste hinzufügen
                Speichern(dateipfad); // Bibliothek automatisch speichern
                Console.WriteLine("Buch hinzugefügt und Bibliothek gespeichert!");
            }

            // Speichert die Liste der Verlage in eine Datei
            public void VerlagsListeDrucken(string dateipfad)
            {
                using (StreamWriter writer = new StreamWriter(dateipfad)) // Datei öffnen
                {
                    writer.WriteLine("Liste der Verlage:\n"); // Überschrift schreiben
                    foreach (var buch in Buecher) // Über alle Bücher iterieren
                    {
                        writer.WriteLine($"- {buch.Verlag.Name}"); // Verlag des Buches schreiben
                    }
                }
                Console.WriteLine($"Verlagsliste wurde in {dateipfad} gespeichert.");
            }

            // Speichert die Liste der Autoren in eine Datei
            public void AutorenListeDrucken(string dateipfad)
            {
                using (StreamWriter writer = new StreamWriter(dateipfad)) // Datei öffnen
                {
                    writer.WriteLine("Liste der Autoren:\n"); // Überschrift schreiben
                    foreach (var buch in Buecher) // Über alle Bücher iterieren
                    {
                        writer.WriteLine($"- {buch.Autor.Name} ({buch.Autor.Jahrgang})"); // Autor des Buches schreiben
                    }
                }
                Console.WriteLine($"Autorenliste wurde in {dateipfad} gespeichert.");
            }

            // Berechnet die totale Seitenanzahl und speichert das Ergebnis
            public void TotaleSeiten(string dateipfad)
            {
                int totaleSeiten = 0; // Variable für die Summe der Seitenanzahl
                foreach (var buch in Buecher) // Über alle Bücher iterieren
                {
                    totaleSeiten += buch.AnzahlSeiten; // Seitenanzahl hinzufügen
                }
                using (StreamWriter writer = new StreamWriter(dateipfad)) // Datei öffnen
                {
                    writer.WriteLine($"Die Bibliothek hat insgesamt {totaleSeiten} Seiten."); // Ergebnis schreiben
                }
                Console.WriteLine($"Totale Seitenanzahl wurde in {dateipfad} gespeichert.");
            }

            // Speichert die Details der Bücher in eine Datei
            public void BuchDetailsSpeichern(string dateipfad)
            {
                using (StreamWriter writer = new StreamWriter(dateipfad)) // Datei öffnen
                {
                    writer.WriteLine("Buchdetails:\n"); // Überschrift schreiben
                    foreach (var buch in Buecher) // Über alle Bücher iterieren
                    {
                        writer.WriteLine($"{buch.Titel} (ISBN: {buch.ISBN}) hat {buch.AnzahlSeiten} Seiten."); // Buchdetails schreiben
                        writer.WriteLine($"Autor: {buch.Autor.Name}, Verlag: {buch.Verlag.Name}\n"); // Autor und Verlag schreiben
                    }
                }
                Console.WriteLine($"Buchdetails wurden in {dateipfad} gespeichert.");
            }

            // Speichert die Bibliothek in eine Datei
            public void Speichern(string dateipfad)
            {
                using (StreamWriter writer = new StreamWriter(dateipfad)) // Datei öffnen
                {
                    foreach (var buch in Buecher) // Über alle Bücher iterieren
                    {
                        // Buchdetails im CSV-Format speichern
                        writer.WriteLine($"{buch.Titel}|{buch.ISBN}|{buch.AnzahlSeiten}|{buch.Verlag.Name}|{buch.Autor.Name}|{buch.Autor.Jahrgang}");
                    }
                }
                Console.WriteLine("Bibliothek wurde gespeichert.");
            }

            // Lädt die Bibliothek aus einer Datei
            public static Bibliothek Laden(string dateipfad)
            {
                Bibliothek bibliothek = new Bibliothek(); // Neue leere Bibliothek erstellen

                if (!File.Exists(dateipfad)) // Überprüfen, ob die Datei existiert
                {
                    Console.WriteLine("Datei nicht gefunden. Neue Bibliothek wird erstellt.");
                    return bibliothek;
                }

                using (StreamReader reader = new StreamReader(dateipfad)) // Datei öffnen
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Jede Zeile lesen
                    {
                        string[] teile = line.Split('|'); // Zeile in Teile splitten
                        if (teile.Length == 6) // Überprüfen, ob alle Daten vorhanden sind
                        {
                            // Daten extrahieren und ein neues Buch erstellen
                            string titel = teile[0];
                            int isbn = int.Parse(teile[1]);
                            int seiten = int.Parse(teile[2]);
                            string verlagName = teile[3];
                            string autorName = teile[4];
                            int jahrgang = int.Parse(teile[5]);

                            Verlag verlag = new Verlag(verlagName); // Verlag erstellen
                            Autor autor = new Autor(autorName, jahrgang); // Autor erstellen
                            Buch buch = new Buch(titel, isbn, seiten, verlag, autor); // Buch erstellen

                            bibliothek.Buecher.Add(buch); // Buch zur Bibliothek hinzufügen
                        }
                    }
                }

                Console.WriteLine("Bibliothek wurde geladen.");
                return bibliothek; // Geladene Bibliothek zurückgeben
            }

            // Zeigt den Inhalt einer Datei an
            public static void AusgabenAnzeigen(string dateipfad)
            {
                if (File.Exists(dateipfad)) // Überprüfen, ob die Datei existiert
                {
                    Console.WriteLine($"\nInhalt der Datei {dateipfad}:\n");
                    using (StreamReader reader = new StreamReader(dateipfad)) // Datei öffnen
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null) // Jede Zeile lesen
                        {
                            Console.WriteLine(line); // Zeile ausgeben
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Datei {dateipfad} nicht gefunden.");
                }
            }
        }

        // Klasse zur Darstellung eines Buches
        private class Buch
        {
            public string Titel { get; private set; } // Titel des Buches
            public int ISBN { get; private set; } // ISBN des Buches
            public int AnzahlSeiten { get; private set; } // Seitenanzahl
            public Verlag Verlag { get; private set; } // Verlag
            public Autor Autor { get; private set; } // Autor

            // Konstruktor, um ein Buch zu erstellen
            public Buch(string titel, int isbn, int anzahlSeiten, Verlag verlag, Autor autor)
            {
                Titel = titel;
                ISBN = isbn;
                AnzahlSeiten = anzahlSeiten;
                Verlag = verlag;
                Autor = autor;
            }
        }

        // Klasse zur Darstellung eines Verlags
        private class Verlag
        {
            public string Name { get; private set; } // Name des Verlags

            public Verlag(string name)
            {
                Name = name; // Name setzen
            }
        }

        // Klasse zur Darstellung eines Autors
        private class Autor
        {
            public string Name { get; private set; } // Name des Autors
            public int Jahrgang { get; private set; } // Geburtsjahr des Autors

            public Autor(string name, int jahrgang)
            {
                Name = name; // Name setzen
                Jahrgang = jahrgang; // Jahrgang setzen
            }
        }

        static void Main(string[] args)
        {
            // Dateipfade definieren
            string bibliothekDatei = "bibliothek.txt";
            string verlagsListeDatei = "verlagsliste.txt";
            string autorenListeDatei = "autorenliste.txt";
            string totaleSeitenDatei = "totale_seiten.txt";
            string buchDetailsDatei = "buchdetails.txt";

            Bibliothek bibliothek = Bibliothek.Laden(bibliothekDatei); // Bibliothek laden

            while (true)
            {
                // Menü anzeigen
                Console.WriteLine("\n--- Bibliothek Menü ---");
                Console.WriteLine("1. Buch hinzufügen");
                Console.WriteLine("2. Bücher speichern und anzeigen");
                Console.WriteLine("3. Verlagsliste speichern und anzeigen");
                Console.WriteLine("4. Autorenliste speichern und anzeigen");
                Console.WriteLine("5. Totale Seitenanzahl speichern und anzeigen");
                Console.WriteLine("6. Bibliothek speichern");
                Console.WriteLine("7. Programm beenden");
                Console.Write("Wählen Sie eine Option: ");
                string auswahl = Console.ReadLine(); // Benutzer-Eingabe lesen

                switch (auswahl)
                {
                    case "1":
                        // Buchdetails abfragen
                        Console.Write("Titel: ");
                        string titel = Console.ReadLine();

                        Console.Write("ISBN: ");
                        int isbn = int.Parse(Console.ReadLine());

                        Console.Write("Anzahl Seiten: ");
                        int seiten = int.Parse(Console.ReadLine());

                        Console.Write("Verlag: ");
                        string verlagName = Console.ReadLine();
                        Verlag verlag = new Verlag(verlagName);

                        Console.Write("Autor Name: ");
                        string autorName = Console.ReadLine();

                        Console.Write("Autor Jahrgang: ");
                        int jahrgang = int.Parse(Console.ReadLine());
                        Autor autor = new Autor(autorName, jahrgang);

                        Buch buch = new Buch(titel, isbn, seiten, verlag, autor); // Neues Buch erstellen
                        bibliothek.BuchHinzufuegen(buch, bibliothekDatei); // Buch hinzufügen und speichern
                        break;

                    case "2":
                        // Buchdetails speichern und anzeigen
                        bibliothek.BuchDetailsSpeichern(buchDetailsDatei);
                        Bibliothek.AusgabenAnzeigen(buchDetailsDatei);
                        break;

                    case "3":
                        // Verlagsliste speichern und anzeigen
                        bibliothek.VerlagsListeDrucken(verlagsListeDatei);
                        Bibliothek.AusgabenAnzeigen(verlagsListeDatei);
                        break;

                    case "4":
                        // Autorenliste speichern und anzeigen
                        bibliothek.AutorenListeDrucken(autorenListeDatei);
                        Bibliothek.AusgabenAnzeigen(autorenListeDatei);
                        break;

                    case "5":
                        // Totale Seitenanzahl speichern und anzeigen
                        bibliothek.TotaleSeiten(totaleSeitenDatei);
                        Bibliothek.AusgabenAnzeigen(totaleSeitenDatei);
                        break;

                    case "6":
                        // Bibliothek speichern
                        bibliothek.Speichern(bibliothekDatei);
                        break;

                    case "7":
                        // Programm beenden
                        return;

                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }
    }
}

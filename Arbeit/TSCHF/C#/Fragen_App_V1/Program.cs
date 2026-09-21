using System;
using System.Collections.Generic;

class Frage
{   
    public string Text { get; set; }
    public List<string> Antworten { get; set; }
    public int Richtige_Antwort { get; set; }
}

class FragenManager
{
    private List<Frage> fragen;
    private int aktuelle_Frage;
    public int Punkte { get; private set; }

    public FragenManager()
    {
        fragen = new List<Frage>
        {
            new Frage {
                Text = "Wozu wird eine Firewall verwendet",
                Antworten = new List<string> {
                    "Zum Abspeichern von Daten",
                    "Zur Überwachung und Kontrolle von Netzwerkverkehr",
                    "Zum Schreiben von Software",
                    "Zum Komprimieren von Dateien"
                },
                Richtige_Antwort = 1    // Index 1 - Antwort 2
            },
            new Frage {
                Text = "Was ist ein Webservice",
                Antworten = new List<string> {
                    "Ein Online-Shop",
                    "Ein Dienst, der über ein Netzwerk zugänglich ist",
                    "Ein lokales Programm zur Datenverarbeitung",
                    "Ein Browser-Plugin"
                },
                Richtige_Antwort = 1 // Index 1 - Antwort 2
            },
            new Frage {
                Text = "Was bedeutet der Begriff \"CMS\"",
                Antworten = new List<string> {
                    "Computer Management System",
                    "Content Management System",
                    "Centralized Media Server",
                    "Code Management Software"
                },
                Richtige_Antwort = 1 // Index 1 - Antwort 2
            },
            new Frage {
                Text = "Was bedeutet die Abkürzung SSS",
                Antworten = new List<string> {
                    "Style Sheet Syntax",
                    "Simple Software Service",
                    "Single Sign-On",
                    "Structured Software System"
                },
                Richtige_Antwort = 2    // Index 2 - Antwort 3
            }
        };

        aktuelle_Frage = 0;
        Punkte = 0;
    }

    public Frage Hole_Aktuelle_Frage()
    {
        return fragen[aktuelle_Frage];
    }

    public bool Beantwortete_Frage(int antwortIndex)
    {
        bool korrekt = antwortIndex == Hole_Aktuelle_Frage().Richtige_Antwort;
        if (korrekt) Punkte++;
        return korrekt;
    }

    public bool Hat_Naechste_Frage()
    {
        return aktuelle_Frage + 1 < fragen.Count;
    }

    public void Naechste_Frage()
    {
        if (Hat_Naechste_Frage())
            aktuelle_Frage++;
    }
}

class Program
{
    static void Main()
    {
        FragenManager manager = new FragenManager();
        Random random = new Random();

        while (true)
        {
            var frage = manager.Hole_Aktuelle_Frage();
            Console.WriteLine("\n" + frage.Text);
            for (int i = 0; i < frage.Antworten.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {frage.Antworten[i]}");
            }

            Console.Write("Deine Antwort [1–4]: ");
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out int antwortIndex)
                && antwortIndex >= 1 && antwortIndex <= frage.Antworten.Count)
            {
                bool korrekt = manager.Beantwortete_Frage(antwortIndex - 1);
                Console.WriteLine(korrekt ? "Richtig!" : "Falsch!");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl von 1 bis 4 eingeben.");
                continue;
            }

            if (manager.Hat_Naechste_Frage())
            {
                manager.Naechste_Frage();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"\n Spiel beendet! Du hast {manager.Punkte} von 4 Punkten erreicht.");
    }
}

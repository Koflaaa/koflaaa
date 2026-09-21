using System;
using System.Collections.Generic;

namespace ZeiterfassungProgramm
{
    class TimeEntry
    {
        public DateTime Date { get; set; } // Datum des Zeiteintrags
        public TimeSpan StartTime { get; set; } // Startzeit des Zeiteintrags
        public TimeSpan EndTime { get; set; } // Endzeit des Zeiteintrags
    }

    class Program
    {
        protected static List<TimeEntry> timeEntries = new(); // Liste zur Speicherung der Zeiteinträge

        static void Main()
        {
            bool running = true;

            while (running)
            {
                // Hauptmenü anzeigen
                Console.WriteLine("Terminkalender - Bitte wählen:");
                Console.WriteLine("1. Termin hinzufügen");
                Console.WriteLine("2. Termineinträge und Gesamt-Summe ausgeben");
                Console.WriteLine("3. Programm beenden");

                // Benutzereingabe lesen
                string choice = Console.ReadLine();

                // Aktion basierend auf der Benutzereingabe ausführen
                switch (choice)
                {
                    case "1":
                        AddTimeEntry(); // Methode zum Hinzufügen eines Zeiteintrags aufrufen
                        break;
                    case "2":
                        ShowTimeEntries(); // Methode zum Anzeigen der Zeiteinträge und der Gesamtstunden aufrufen
                        break;
                    case "3":
                        Console.WriteLine("Programm beendet.");
                        running = false; // Programm beenden
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wähle 1, 2 oder 3."); // Fehlermeldung für ungültige Auswahl
                        break;
                }
            }
        }

        static void AddTimeEntry()
        {
            var newEntry = CreateEntry(); // Methode zum Erstellen eines neuen Zeiteintrags aufrufen

            // Überprüfen, ob ein gültiger Zeiteintrag erstellt wurde
            if (newEntry != null)
            {
                timeEntries.Add(newEntry); // Zeiteintrag zur Liste hinzufügen
                Console.WriteLine("Termin hinzugefügt!"); // Bestätigungsmeldung anzeigen
            }
            else
            {
                Console.WriteLine("Kein Termin hinzugefügt. Bitte überprüfe deine Eingaben."); // Fehlermeldung für ungültige Eingaben
            }
        }

        static void ShowTimeEntries()
        {
            // Überprüfen, ob Zeiteinträge vorhanden sind
            if (timeEntries.Count == 0)
            {
                Console.WriteLine("Keine Termine vorhanden."); // Benachrichtigung über fehlende Zeiteinträge
                return;
            }

            // Zeiteinträge anzeigen
            Console.WriteLine("Einträge:");
            foreach (var entry in timeEntries)
            {
                Console.WriteLine($"Datum: {entry.Date.ToShortDateString()}, Startzeit: {entry.StartTime}, Endzeit: {entry.EndTime}"); // Details jedes Zeiteintrags anzeigen
            }

            ShowTotalHours(); // Methode zum Anzeigen der Gesamtstunden aufrufen
        }

        static TimeEntry CreateEntry()
        {
            var newEntry = new TimeEntry(); // Neuen Zeiteintrag erstellen

            bool validInput = false;

            while (!validInput)
            {
                // Benutzer zur Eingabe des Datums auffordern und Eingabe validieren
                Console.WriteLine("Bitte gib das Datum ein (TT.MM.JJ):");
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    if (date < DateTime.Today)
                    {
                        Console.WriteLine("Ungültiges Datumsformat oder Datum muss Heute oder in der Zukunft liegen."); // Fehlermeldung für ungültiges Datum
                    }
                }
                else
                {
                    newEntry.Date = date; // Datum setzen
                    validInput = true; // Eingabe als gültig markieren
                }
            }

            validInput = false;

            while (!validInput)
            {
                // Benutzer zur Eingabe der Startzeit auffordern und Eingabe validieren
                Console.WriteLine("Bitte gib die Startzeit ein (hh:mm):");
                if (!TimeSpan.TryParseExact(Console.ReadLine(), "hh\\:mm", null, out TimeSpan startTime))
                {
                    Console.WriteLine("Ungültiges Zeitformat für die Startzeit."); // Fehlermeldung für ungültige Startzeit
                }
                else
                {
                    newEntry.StartTime = startTime; // Startzeit setzen
                    validInput = true; // Eingabe als gültig markieren
                }
            }

            validInput = false;

            while (!validInput)
            {
                // Benutzer zur Eingabe der Endzeit auffordern und Eingabe validieren
                Console.WriteLine("Bitte gib die Endzeit ein (hh:mm):");
                if (!TimeSpan.TryParseExact(Console.ReadLine(), "hh\\:mm", null, out TimeSpan endTime))
                {
                    Console.WriteLine("Ungültiges Zeitformat für die Endzeit."); // Fehlermeldung für ungültige Endzeit
                }
                else
                {
                    if (endTime < newEntry.StartTime)
                    {
                        Console.WriteLine("Ungültiges Format. Endzeit darf nicht kleiner als Startzeit sein!"); // Fehlermeldung für ungültige Endzeit
                    }
                    else
                    {
                        newEntry.EndTime = endTime; // Endzeit setzen
                        validInput = true; // Eingabe als gültig markieren
                    }
                }
            }

            return newEntry; // Neuen Zeiteintrag zurückgeben
        }

        static void ShowTotalHours()
        {
            timeEntries.Sort((entry1, entry2) => entry2.EndTime.CompareTo(entry1.EndTime)); // Zeiteinträge nach Endzeit in absteigender Reihenfolge sortieren

            TimeSpan totalHours = TimeSpan.Zero;

            // Gesamtstunden berechnen
            foreach (var entry in timeEntries)
            {
                if (entry.EndTime > entry.StartTime)
                {
                    totalHours = totalHours.Add(entry.EndTime - entry.StartTime);
                }
            }

            // Gesamtstunden anzeigen
            Console.WriteLine($"Gesamtstunden: {totalHours.Hours} Stunden und {totalHours.Minutes} Minuten");
        }

    }
}

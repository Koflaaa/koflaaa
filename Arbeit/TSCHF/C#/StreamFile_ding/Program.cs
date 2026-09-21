using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = "test.txt"; // Pfad zur Datei

        // Wenn die Datei nicht existiert, wird sie erstellt.
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Die Datei existiert nicht. Es wird eine neue Datei erstellt.");
            await File.WriteAllTextAsync(filePath, string.Empty); // Erstellen einer leeren Datei
        }

        List<string> lines = await ReadFileAsync(filePath);

        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Aktuelle Datei-Inhalte:");
            DisplayFileContents(lines);

            Console.WriteLine("\nWählen Sie eine Option:");
            Console.WriteLine("1: Zeile einfügen");
            Console.WriteLine("2: Zeile löschen");
            Console.WriteLine("3: Datei leeren");
            Console.WriteLine("4: Beenden");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": await InsertLineAsync(lines, filePath); break;
                case "2": await DeleteLineAsync(lines, filePath); break;
                case "3": await ClearFileAsync(filePath); lines.Clear(); break; // Datei leeren
                case "4": keepRunning = false; break;
                default: Console.WriteLine("Ungültige Auswahl."); break;
            }

            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }

    // Datei lesen
    static async Task<List<string>> ReadFileAsync(string filePath)
    {
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
                lines.Add(line);
        }
        return lines;
    }

    // Datei-Inhalte anzeigen
    static void DisplayFileContents(List<string> lines)
    {
        if (lines.Count == 0)
            Console.WriteLine("Die Datei ist leer.");
        else
        {
            for (int i = 0; i < lines.Count; i++)
                Console.WriteLine($"{i + 1}: {lines[i]}");
        }
    }

    // Zeile einfügen
    static async Task InsertLineAsync(List<string> lines, string filePath)
    {
        Console.WriteLine("Geben Sie die Zeilennummer ein, nach der Sie eine neue Zeile einfügen möchten (oder '1' für die erste Zeile):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int lineNumber) && lineNumber >= 1 && lineNumber <= lines.Count + 1)
        {
            if (lineNumber == 1 || lines.Count == 0)
            {
                // Zeile wird immer an erster Stelle eingefügt, wenn die Datei leer ist oder "1" gewählt wird
                Console.WriteLine("Geben Sie den Text ein, den Sie in die erste Zeile einfügen möchten:");
                string newText = Console.ReadLine();
                lines.Insert(0, newText);
            }
            else
            {
                // Zeile nach angegebener Position einfügen
                Console.WriteLine($"Aktuelle Zeile {lineNumber}: {lines[lineNumber - 1]}");
                Console.WriteLine("Geben Sie den Text ein, den Sie nach dieser Zeile einfügen möchten:");
                string newText = Console.ReadLine();
                lines.Insert(lineNumber - 1, newText);
            }

            await File.WriteAllLinesAsync(filePath, lines);
            Console.WriteLine("Die Datei wurde aktualisiert.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zeilennummer ein.");
        }
    }

    // Zeile löschen
    static async Task DeleteLineAsync(List<string> lines, string filePath)
    {
        Console.WriteLine("Geben Sie die Zeilennummer ein, die Sie löschen möchten:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int lineNumber) && lineNumber >= 1 && lineNumber <= lines.Count)
        {
            Console.WriteLine($"Sie haben Zeile {lineNumber}: {lines[lineNumber - 1]} ausgewählt.");
            Console.WriteLine("Möchten Sie diese Zeile wirklich löschen? (j/n)");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() == "j")
            {
                lines.RemoveAt(lineNumber - 1); // Zeile löschen
                await File.WriteAllLinesAsync(filePath, lines);
                Console.WriteLine("Die Zeile wurde gelöscht und die Datei wurde aktualisiert.");
            }
            else
            {
                Console.WriteLine("Löschvorgang abgebrochen.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Zeilennummer.");
        }
    }

    // Datei leeren (nicht löschen)
    static async Task ClearFileAsync(string filePath)
    {
        Console.WriteLine("Möchten Sie die Datei wirklich leeren? (j/n)");
        string confirmation = Console.ReadLine();

        if (confirmation.ToLower() == "j")
        {
            await File.WriteAllTextAsync(filePath, string.Empty); // Datei leeren
            Console.WriteLine("Die Datei wurde geleert.");
        }
        else
        {
            Console.WriteLine("Leeren der Datei abgebrochen.");
        }
    }
}

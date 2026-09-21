using System;
using System.IO;

class Program
{
    static string GetPathFromFile()
    {
        string pathFile = "path.txt";

        if (!File.Exists(pathFile))
        {
            Console.WriteLine("Der Pfad für die Datei wurde noch nicht gespeichert.");
            Console.WriteLine("Bitte geben Sie einen Pfad ein, um ihn zu speichern:");
            string path = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(pathFile))
            {
                writer.WriteLine(path);
            }
            return path;
        }

        using (StreamReader reader = new StreamReader(pathFile))
        {
            return reader.ReadLine();
        }
    }

    static void Main()
    {
        string path = GetPathFromFile();
        string filePath = Path.Combine(path, "namen.txt");
        string lockFilePath = Path.Combine(path, "aktiv.txt");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Personen-Namen Verwaltung");
            Console.WriteLine("1. Namen hinzufügen");
            Console.WriteLine("2. Namen anzeigen");
            Console.WriteLine("3. Namen löschen");
            Console.WriteLine("4. Speicherpfad ändern");
            Console.WriteLine("5. Beenden");
            Console.Write("Ihre Wahl: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AccessWithLock(filePath, lockFilePath, AddName);
                    break;
                case "2":
                    AccessWithLock(filePath, lockFilePath, DisplayNames);
                    break;
                case "3":
                    AccessWithLock(filePath, lockFilePath, DeleteNames);
                    break;
                case "4":
                    ChangePath();
                    path = GetPathFromFile();
                    filePath = Path.Combine(path, "namen.txt");
                    lockFilePath = Path.Combine(path, "aktiv.txt");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe! Drücken Sie eine beliebige Taste, um es erneut zu versuchen.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AccessWithLock(string filePath, string lockFilePath, Action<string> action)
    {
        if (File.Exists(lockFilePath))
        {
            Console.WriteLine("Die Datei 'namen.txt' ist momentan gesperrt. Versuchen Sie es später erneut.");
            Console.ReadKey();
            return;
        }

        try
        {
            // Erstellen der Lock-Datei
            File.Create(lockFilePath).Dispose();

            // Aufruf der übergebenen Aktion (Add, Display, Delete)
            action(filePath);
        }
        finally
        {
            // Löschen der Lock-Datei
            if (File.Exists(lockFilePath))
            {
                File.Delete(lockFilePath);
            }
        }
    }

    static void AddName(string filePath)
    {
        Console.Write("Geben Sie einen Namen ein: ");
        string? name = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(name);
        }

        Console.WriteLine("Name hinzugefügt!");
        Console.ReadKey();
    }

    static void DisplayNames(string filePath)
    {// Checks if the file exists or not
        if (!File.Exists(filePath))
        {// if not, an ERROR-Message will be outputed
            Console.WriteLine("Keine Namen gefunden.");
        }
        else
        {// If it does exist it'll get 
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("Gespeicherte Namen:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
        Console.ReadKey();
    }

    static void DeleteNames(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Die Datei existiert nicht. Nichts zu löschen.");
        }
        else
        {
            File.Delete(filePath);
            Console.WriteLine("Alle Namen wurden gelöscht!");
        }

        Console.ReadKey();
    }

    static void ChangePath()
    {
        Console.WriteLine("Geben Sie einen neuen Speicherpfad ein:");
        string newPath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("path.txt"))
        {
            writer.WriteLine(newPath);
        }

        Console.WriteLine("Pfad erfolgreich geändert!");
        Console.ReadKey();
    }
}

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bibliothek_WPF
{
    public static class FileHelper
    {
        private static string filePath = "bibliothek.txt";

        // Methode zum Speichern der Bibliotheksdaten in eine Datei
        public static void SaveToFile(Bibliothek bibliothek)
        {
            var sb = new StringBuilder();

            // Bücher speichern
            foreach (var buch in bibliothek.Buecher)
            {
                sb.AppendLine($"Buch|{buch.Titel}|{buch.Seiten}");
            }

            // Verlage speichern
            foreach (var verlag in bibliothek.Verlage)
            {
                sb.AppendLine($"Verlag|{verlag.Name}");
            }

            // Autoren speichern
            foreach (var autor in bibliothek.Autoren)
            {
                sb.AppendLine($"Autor|{autor.Name}");
            }

            // Orte speichern
            foreach (var ort in bibliothek.Orte)
            {
                sb.AppendLine($"Ort|{ort.Name}");
            }

            File.WriteAllText(filePath, sb.ToString()); // Inhalt in Datei schreiben
        }

        // Methode zum Laden der Bibliotheksdaten aus einer Datei
        public static void LoadFromFile(Bibliothek bibliothek)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                switch (parts[0])
                {
                    case "Buch":
                        bibliothek.Buecher.Add(new Buch { Titel = parts[1], Seiten = int.Parse(parts[2]) });
                        break;
                    case "Verlag":
                        bibliothek.Verlage.Add(new Verlag { Name = parts[1] });
                        break;
                    case "Autor":
                        bibliothek.Autoren.Add(new Autor { Name = parts[1] });
                        break;
                    case "Ort":
                        bibliothek.Orte.Add(new Ort { Name = parts[1] });
                        break;
                }
            }
        }
    }
}

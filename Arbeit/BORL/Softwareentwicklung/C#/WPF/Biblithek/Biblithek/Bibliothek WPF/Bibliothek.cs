using System.Collections.Generic;

namespace Bibliothek_WPF
{
    public class Bibliothek
    {
        // Listen für Bücher, Verlage, Autoren und Orte
        public List<Buch> Buecher { get; set; }
        public List<Verlag> Verlage { get; set; }
        public List<Autor> Autoren { get; set; }
        public List<Ort> Orte { get; set; }

        // Konstruktor: Initialisierung der Listen und Laden der Daten aus der Datei
        public Bibliothek()
        {
            Buecher = new List<Buch>();
            Verlage = new List<Verlag>();
            Autoren = new List<Autor>();
            Orte = new List<Ort>();

            FileHelper.LoadFromFile(this); // Daten aus Datei laden
        }

        // Methoden zum Hinzufügen und Entfernen von Büchern, Verlagen, Autoren und Orten
        public void AddBuch(Buch buch)
        {
            Buecher.Add(buch);
        }

        public void RemoveBuch(Buch buch)
        {
            Buecher.Remove(buch);
        }

        public void AddVerlag(Verlag verlag)
        {
            Verlage.Add(verlag);
        }

        public void RemoveVerlag(Verlag verlag)
        {
            Verlage.Remove(verlag);
        }

        public void AddAutor(Autor autor)
        {
            Autoren.Add(autor);
        }

        public void RemoveAutor(Autor autor)
        {
            Autoren.Remove(autor);
        }

        public void AddOrt(Ort ort)
        {
            Orte.Add(ort);
        }

        public void RemoveOrt(Ort ort)
        {
            Orte.Remove(ort);
        }
    }
}

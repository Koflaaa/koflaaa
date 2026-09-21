using System;
using System.Collections.Generic;

// Definition of the Bibliothek class
public class Bibliothek
{
    // Lists to hold books, publishers, authors, and locations
    private List<Buch> buecher;
    private List<Verlag> verlage;
    private List<Autor> autoren;
    private List<Ort> orte;

    // Constructor to initialize the lists
    public Bibliothek()
    {
        buecher = new List<Buch>();
        verlage = new List<Verlag>();
        autoren = new List<Autor>();
        orte = new List<Ort>();
    }

    // Method to add a book to the library
    public void AddBuch(Buch buch)
    {
        buecher.Add(buch);
    }

    // Method to add a publisher to the library
    public void AddVerlag(Verlag verlag)
    {
        verlage.Add(verlag);
    }

    // Method to add an author to the library
    public void AddAutor(Autor autor)
    {
        autoren.Add(autor);
    }

    // Method to add a location to the library
    public void AddOrt(Ort ort)
    {
        orte.Add(ort);
    }

    // Method to print the list of publishers
    public void VerlagsListeDrucken()
    {
        Console.WriteLine("Verlagsliste:");
        foreach (var verlag in verlage)
        {
            Console.WriteLine(verlag.Name);
        }
    }

    // Method to print the list of authors
    public void AutorenListeDrucken()
    {
        Console.WriteLine("Autorenliste:");
        foreach (var autor in autoren)
        {
            Console.WriteLine(autor.Name);
        }
    }

    // Method to print the total number of pages of all books in the library
    public void TotalSeitenAusgeben()
    {
        int totalSeiten = 0;
        foreach (var buch in buecher)
        {
            totalSeiten += buch.Seiten;
        }
        Console.WriteLine($"Total Seiten: {totalSeiten}");
    }
}

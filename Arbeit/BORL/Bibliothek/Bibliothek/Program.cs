// Definition of the Program class
using System;

public class Program
{
    // Main method
    public static void Main(string[] args)
    {
        // Instantiate the library
        Bibliothek bibliothek = new Bibliothek();
		string buch[] = {4}


		for (int i = 0; i < 4; i++)
		{
			Console.WriteLine("Geben Sie den Namen des {0}. Buches ein.", i+1);
			buch[i] = Console.ReadLine();
		}
		
		
        // Instantiate some books
        Buch buch1 = new Buch("Buch Eins", 100);
        Buch buch2 = new Buch("Buch Zwei", 150);
        Buch buch3 = new Buch("Buch Drei\n", 200);

        // Instantiate some publishers
        Verlag verlag1 = new Verlag("The Ultimate Universe");
        Verlag verlag2 = new Verlag("Imperial Galaxy\n");

        // Instantiate some authors
        Autor autor1 = new Autor("Shakes Beer");
        Autor autor2 = new Autor("Zwei Stein\n");

        // Instantiate some locations
        Ort ort1 = new Ort("HOGWARTS");
        Ort ort2 = new Ort("HUFFLEPUFF\n");

        // Add books to the library
        bibliothek.AddBuch(buch1);
        bibliothek.AddBuch(buch2);
        bibliothek.AddBuch(buch3);

        // Add publishers to the library
        bibliothek.AddVerlag(verlag1);
        bibliothek.AddVerlag(verlag2);

        // Add authors to the library
        bibliothek.AddAutor(autor1);
        bibliothek.AddAutor(autor2);

        // Add locations to the library
        bibliothek.AddOrt(ort1);
        bibliothek.AddOrt(ort2);

        // Print the list of publishers
        bibliothek.VerlagsListeDrucken();

        // Print the list of authors
        bibliothek.AutorenListeDrucken();

        // Print the total number of pages of all books in the library
        bibliothek.TotalSeitenAusgeben();

        Console.WriteLine("\n10 POINTS FOR HOUSE SLYTHERIN!");
        Console.ReadKey();
    }
}

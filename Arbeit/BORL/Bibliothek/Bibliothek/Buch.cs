// Definition of the Buch class
public class Buch
{
    // Properties
    public string Titel { get; set; }
    public int Seiten { get; set; }

    // Constructor
    public Buch(string titel, int seiten)
    {
        Titel = titel;
        Seiten = seiten;
    }
}
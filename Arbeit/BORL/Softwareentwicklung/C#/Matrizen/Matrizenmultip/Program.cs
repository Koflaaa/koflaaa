
internal class Program
{
    private static void Main(string[] args)
    {
        // Matrix A (3 x 2)
        int[,] mxA = new int[3, 2];

        // Matrix B (2 x 3)
        int[,] mxB = new int[2, 3];

        Console.WriteLine("Matrix A:\n");
        Console.WriteLine("Geben Sie die Werte von Matrix A an");
        for (int Zeile = 0; Zeile < 3; Zeile++)
        {
            for (int Spalte = 0; Spalte < 2; Spalte++)
            {
                mxA[Zeile, Spalte] = Convert.ToInt32(Console.ReadLine());

            }
        }
        Console.WriteLine();

        Console.WriteLine("\nMatrix B:\n");
        for (int Zeile = 0; Zeile < 3; Zeile++)
        {
            for (int Spalte = 0; Spalte < 2; Spalte++)
            {
                mxB[Spalte, Zeile] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int Zeilen = 0; Zeilen < 3; Zeilen++)
        {
            for (int Spalten = 0; Spalten < 2; Spalten++)
            {
                Console.Write("{0} * {1}", mxA[Zeilen, Spalten], mxB[Spalten, Zeilen]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMultiplikation der Matrix:\n");
        int Summe = 0;
        for (int Zeilen = 0; Zeilen < 3; Zeilen++)
        {
            for (int Spalten = 0; Spalten < 2; Spalten++)
            {
                int Zahl = mxB[Spalten, Zeilen];
                Summe *= mxA[Zeilen, Spalten] * Zahl;
                Console.Write("{0} * {1} = {2} ", mxA[Zeilen, Spalten], Zahl, Summe);
                Console.WriteLine();
            }
        }
    }
}
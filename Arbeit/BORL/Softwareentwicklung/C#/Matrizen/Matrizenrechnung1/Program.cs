using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = new int[2, 3];
        int[,] matrixB = new int[3, 2];
        int[,] summe = new int[2, 2];

        // Eingabe der Werte für Matrix 1
        Console.WriteLine("Geben Sie die Werte für Matrix 1 ein:");
        for (int Zeile = 0; Zeile < 2; Zeile++)
        {
            for (int Spalte = 0; Spalte < 3; Spalte++)
            {
                Console.Write($"Matrix1[{Zeile},{Spalte}]: ");
                matrixA[Zeile, Spalte] = int.Parse(Console.ReadLine());
            }
        }

        // Eingabe der Werte für Matrix 2
        Console.WriteLine("Geben Sie die Werte für Matrix 2 ein:");
        for (int Zeile = 0; Zeile < 3; Zeile++)
        {
            for (int Spalte = 0; Spalte < 2; Spalte++)
            {
                Console.Write($"Matrix2[{Zeile},{Spalte}]: ");
                matrixB[Zeile, Spalte] = int.Parse(Console.ReadLine());
            }
        }

        //Ausgabe in Matrixform
        Console.WriteLine();

        for (int Zeile = 0; Zeile < 2; Zeile++)
        {
            for (int Spalte = 0; Spalte < 3; Spalte++)
            {
                Console.WriteLine("{0} * {1}", matrixA[Zeile,Spalte], matrixB[Spalte,Zeile]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        // Multiplikation
        for (int Zeile = 0; Zeile < 2; Zeile++)
        {
            for (int Spalte = 0; Spalte < 2; Spalte++)
            {
                for (int k = 0; k < 3; k++)
                {
                    summe[Zeile, Spalte] += matrixA[Zeile, k] * matrixB[k, Spalte];
                }
            }
        }

        // Ausgabe des Ergebnisses
        Console.WriteLine("Das Ergebnis der Multiplikation ist:");
        for (int Zeile = 0; Zeile < 2; Zeile++)
        {
            for (int Spalte = 0; Spalte < 2; Spalte++)
            {
                Console.Write(summe[Zeile, Spalte] + " ");
            }
            Console.WriteLine();
        }
        
    }
}

using System;
class Programm
{
    public static void Main()
    {
        //Matrix2x2();
        //Matrix3x3(); 
        MatrixMultipl();
    }
    public static void Matrix2x2()
    {
        int Zeile, Spalte, n;
        int[,] MatrixA = new int[3, 3];
        int[,] MatrixB = new int[3, 3];
        int[,] Summe = new int[3, 3];

        Console.Write("\n\nAddition zweier Matrizen\n");
        n = 2;

        Console.Write("\nGeben Sie die Werte der ersten Matrix ein\n\n");
        for (Zeile = 0; Zeile < 3; Zeile++)
        {
            for (Spalte = 0; Spalte < 3; Spalte++)
            {
                Console.Write("MatrixA - [{0},{1}]: ", Zeile, Spalte);
                MatrixA[Zeile, Spalte] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("\n\nGeben Sie die Werte der zweiten Matrix ein:\n\n");
        for (Zeile = 0; Zeile < 3; Zeile++)
        {
            for (Spalte = 0; Spalte < 3; Spalte++)
            {
                Console.Write("MatrixB - [{0},{1}] : ", Zeile, Spalte);
                MatrixB[Zeile, Spalte] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nErste Matrix:\n");
        for (Zeile = 0; Zeile < 3; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < 3; Spalte++)
            {
                Console.Write("{0}\t", MatrixA[Zeile, Spalte]);
            }
                
        }

        Console.Write("\nZweite Matrix:\n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < n; Spalte++)
            {
                Console.Write("{0}\t", MatrixB[Zeile, Spalte]);
            }
        }

        for (Zeile = 0; Zeile < n; Zeile++)
        {
            for (Spalte = 0; Spalte < n; Spalte++)
            {
                Summe[Zeile, Spalte] = MatrixA[Zeile, Spalte] + MatrixB[Zeile, Spalte];

            }
        }
            
        Console.Write("\nDie Summe ist: \n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < n; Spalte++)
                Console.Write("{0}\t", Summe[Zeile, Spalte]);
        }
        Console.Write("\n\n");
    }
    public static void Matrix3x3()
    {
        int Zeile, Spalte, n;
        int[,] MatrixA = new int[4, 4];
        int[,] MatrixB = new int[4, 4];
        int[,] Summe = new int[4, 4];

        Console.Write("\n\nAddition zweier Matrizen\n");
        n = 3;

        Console.Write("\nGeben Sie die Werte der ersten Matrix ein\n\n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            for (Spalte = 0; Spalte < n; Spalte++)
            {
                Console.Write("MatrixA - [{0},{1}]: ", Zeile, Spalte);
                MatrixA[Zeile, Spalte] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("\n\nGeben Sie die Werte der zweiten Matrix ein:\n\n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            for (Spalte = 0; Spalte < n; Spalte++)
            {
                Console.Write("MatrixB - [{0},{1}] : ", Zeile, Spalte);
                MatrixB[Zeile, Spalte] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nErste Matrix:\n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < n; Spalte++)
                Console.Write("{0}\t", MatrixA[Zeile, Spalte]);
        }

        Console.Write("\nZweite Matrix:\n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < n; Spalte++)
                Console.Write("{0}\t", MatrixB[Zeile, Spalte]);
        }

        for (Zeile = 0; Zeile < n; Zeile++)
        {
            for (Spalte = 0; Spalte < n; Spalte++)
            {
                Summe[Zeile, Spalte] = MatrixA[Zeile, Spalte] + MatrixB[Zeile, Spalte];
            }
        }
                
        Console.Write("\nDie Summe ist: \n");
        for (Zeile = 0; Zeile < n; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < n; Spalte++)
                Console.Write("{0}\t", Summe[Zeile, Spalte]);
        }
        Console.Write("\n\n");
    }
    public static void MatrixMultipl()
    {
        int Zeile, Spalte;
        int[,] MatrixA = new int[2, 3];
        int[,] MatrixB = new int[3, 2];
        int[,] Summe = new int[3, 3];

        Console.Write("\n\nAddition zweier Matrizen\n");

        Console.Write("\nGeben Sie die Werte der ersten Matrix ein\n\n");
        for (Spalte = 0; Spalte < 3; Spalte++)
        {
            for (Zeile = 0; Zeile < 2; Zeile++)
            {
                Console.Write("MatrixA - [{0},{1}]: ", Spalte, Zeile);
                MatrixA[Spalte, Zeile] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\n\nGeben Sie die Werte der zweiten Matrix ein:\n\n");
        for (Spalte = 0; Spalte < 3; Spalte++)
        {
            for (Zeile = 0; Zeile < 2; Zeile++)
            {
                Console.Write("MatrixB - [{0},{1}]: ", Spalte, Zeile);
                MatrixB[Spalte, Zeile] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nErste Matrix:\n");
        for (Spalte = 0; Spalte < 3; Spalte++)
        {
            Console.Write("\n");
            for (Zeile = 0; Zeile < 2; Zeile++)
                Console.Write("{0}\t", MatrixA[Spalte, Zeile]);
        }

        Console.Write("\nZweite Matrix:\n");
        for (Zeile = 0; Zeile < 3; Zeile++)
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < 2; Spalte++)
                Console.Write("{0}\t", MatrixB[Zeile,Spalte]);
        }
        for (Zeile = 0; Zeile < 3; Zeile++)
            for (Spalte = 0; Spalte < 3; Spalte++)
                Summe[Zeile,Spalte] += MatrixA[Zeile, Spalte] * MatrixB[Zeile, Spalte];
        Console.Write("\nDie Summe ist: \n");
        for (Zeile = 0; Zeile < 3; Zeile++) 
        {
            Console.Write("\n");
            for (Spalte = 0; Spalte < 3; Spalte++)
                Console.Write("{0}\t", Summe);
        }
        Console.Write("\n\n");
    }
}

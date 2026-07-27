
//  Die Inverse einer 4x4 Matrix,  Getestet und Funktioniert! (KEW+PPP):

using System;

class Program_2
{
    static void Main()
    {
        // Die 4x4 Matrix erzeugen
        double[,] matrix = new double[4, 4];        
        for (int Zeile = 0; Zeile < 4; Zeile++)
        {
            for (int Spalte = 0; Spalte < 4; Spalte++)
            {
                Console.Write("matrix[{0}, {1}] = ", Zeile, Spalte);
                matrix[Zeile, Spalte] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        // Zuerst die Determinante der 4x4 Matrix berechnen
        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[0, 2];
        double d = matrix[0, 3];
        double e = matrix[1, 0];
        double f = matrix[1, 1];
        double g = matrix[1, 2];
        double h = matrix[1, 3];
        double i = matrix[2, 0];
        double j = matrix[2, 1];
        double k = matrix[2, 2];
        double l = matrix[2, 3];
        double m = matrix[3, 0];
        double n = matrix[3, 1];
        double o = matrix[3, 2];
        double p = matrix[3, 3];

        double determinante = a * (f * (k * p - l * o) - g * (j * p - l * n) + h * (j * o - k * n))
                            - b * (e * (k * p - l * o) - g * (i * p - l * m) + h * (i * o - k * m))
                            + c * (e * (j * p - l * n) - f * (i * p - l * m) + h * (i * n - j * m))
                            - d * (e * (j * o - k * n) - f * (i * o - k * m) + g * (i * n - j * m));


        if (determinante == 0)     // Wenn die Determinante NULL ist, existiert keine Inverse
        {
            Console.WriteLine("Matrix ist Singular, die Inverse existiert nicht.");
        }
        else
        {
            Console.WriteLine("{0}\n", determinante);

            // Ok, Determinante ist NICHT Null, Inverse kann also berechnet werden

            double[,] inverse = new double[4, 4];     // Die 4x4 Inverse Matrix

            inverse[0, 0] = (f * (k * p - l * o) - g * (j * p - l * n)+ h * (j * o - k * n)) / determinante;
            inverse[0, 1] = -(b * (k * p - l * o) - c * (j * p - l * n)+ d * (j * o - k * n)) / determinante;
            inverse[0, 2] = (b * (g * p - h * o) - c * (f * p - h * n)+ d * (f * o - g * n)) / determinante;
            inverse[0, 3] = -(b * (g * l - h * k) - c * (f * l - h * j)+ d * (f * k - g * j)) / determinante;

            inverse[1, 0] = -(e * (k * p - l * o) - g * (i * p - l * m)+ h * (i * o - k * m)) / determinante;
            inverse[1, 1] = (a * (k * p - l * o) - c * (i * p - l * m)+ d * (i * o - k * m)) / determinante;
            inverse[1, 2] = -(a * (g * p - h * o) - c * (e * p - h * m)+ d * (e * o - g * m)) / determinante;
            inverse[1, 3] = (a * (g * l - h * k) - c * (e * l - h * i)+ d * (e * k - g * i)) / determinante;

            inverse[2, 0] = (e * (j * p - l * n) - f * (i * p - l * m)+ h * (i * n - j * m)) / determinante;
            inverse[2, 1] = -(a * (j * p - l * n) - b * (i * p - l * m)+ d * (i * n - j * m)) / determinante;
            inverse[2, 2] = (a * (f * p - h * n) - b * (e * p - h * m)+ d * (e * n - f * m)) / determinante;
            inverse[2, 3] = -(a * (f * l - h * j) - b * (e * l - h * i)+ d * (e * j - f * i)) / determinante;

            inverse[3, 0] = -(e * (j * o - k * n) - f * (i * o - k * m)+ g * (i * n - j * m)) / determinante;
            inverse[3, 1] = (a * (j * o - k * n) - b * (i * o - k * m)+ c * (i * n - j * m)) / determinante;
            inverse[3, 2] = -(a * (f * o - g * n) - b * (e * o - g * m)+ c * (e * n - f * m)) / determinante;
            inverse[3, 3] = (a * (f * k - g * j) - b * (e * k - g * i)+ c * (e * j - f * i)) / determinante;

            // Und jetzt die Inverse Matrix in Console ausgeben

            Console.WriteLine("Inverse Matrix:");
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(" {0:F5} \t", inverse[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}







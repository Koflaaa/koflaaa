using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Matrixinverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrix2x2();
            matrix4x4();
        }
        public static void matrix2x2()
        {
            double[,] matrixA = new double[2, 2];

            //Eingabe der Matrix Werte
            Console.WriteLine("Geben Sie die Werte der Matrix ein:");
            for (int Zeile = 0; Zeile < 2; Zeile++)
            {
                for (int Spalte = 0; Spalte < 2; Spalte++)
                {
                    Console.Write("matrix[{0}, {1}] = ", Zeile, Spalte);
                    matrixA[Zeile, Spalte] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ausgabe der eingegebenen Werte in Matrix Form
            for (int Zeile = 0; Zeile < 2; Zeile++)
            {
                for (int Spalte = 0; Spalte < 2; Spalte++)
                {
                    Console.WriteLine("{0} * {1}", matrixA[Zeile, 0], matrixA[Spalte, 0]);
                }
            }
            double Ergebnis = matrixA[0, 0] * matrixA[1, 1] - matrixA[0, 1] * matrixA[1, 0];

            // Überprüft, ob Matrix invertierbar ist
            if (Ergebnis == 0)
            {
                Console.WriteLine("Die Matrix ist nicht invertierbar.");
            }
            else
            {
                // Berechne die Inverse der 2x2 Matrix
                double inverseA =  matrixA[1, 1] / Ergebnis;
                double inverseB = -matrixA[0, 1] / Ergebnis;
                double inverseC = -matrixA[1, 0] / Ergebnis;
                double inverseD =  matrixA[0, 0] / Ergebnis;

                //Ausgabe der Matrix
                Console.WriteLine("Die Inverse der Matrix ist:");
                Console.WriteLine("  {0:F1} {1:F1}", inverseA, inverseB);
                Console.WriteLine(" {0:F1}  {1:F1}", inverseC, inverseD);

            }
        }

        public static void matrix4x4()
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


            if (determinante == 0)     
            {
                Console.WriteLine("Matrix ist Singular, die Inverse existiert nicht.");
            }
            else
            {
                Console.WriteLine("{0}\n", determinante);


                double[,] inverse = new double[4, 4];     // Die 4x4 Inverse Matrix

                inverse[0, 0] = (f * (k * p - l * o) - g * (j * p - l * n) + h * (j * o - k * n)) / determinante;
                inverse[0, 1] = -(b * (k * p - l * o) - c * (j * p - l * n) + d * (j * o - k * n)) / determinante;
                inverse[0, 2] = (b * (g * p - h * o) - c * (f * p - h * n) + d * (f * o - g * n)) / determinante;
                inverse[0, 3] = -(b * (g * l - h * k) - c * (f * l - h * j) + d * (f * k - g * j)) / determinante;

                inverse[1, 0] = -(e * (k * p - l * o) - g * (i * p - l * m) + h * (i * o - k * m)) / determinante;
                inverse[1, 1] = (a * (k * p - l * o) - c * (i * p - l * m) + d * (i * o - k * m)) / determinante;
                inverse[1, 2] = -(a * (g * p - h * o) - c * (e * p - h * m) + d * (e * o - g * m)) / determinante;
                inverse[1, 3] = (a * (g * l - h * k) - c * (e * l - h * i) + d * (e * k - g * i)) / determinante;

                inverse[2, 0] = (e * (j * p - l * n) - f * (i * p - l * m) + h * (i * n - j * m)) / determinante;
                inverse[2, 1] = -(a * (j * p - l * n) - b * (i * p - l * m) + d * (i * n - j * m)) / determinante;
                inverse[2, 2] = (a * (f * p - h * n) - b * (e * p - h * m) + d * (e * n - f * m)) / determinante;
                inverse[2, 3] = -(a * (f * l - h * j) - b * (e * l - h * i) + d * (e * j - f * i)) / determinante;

                inverse[3, 0] = -(e * (j * o - k * n) - f * (i * o - k * m) + g * (i * n - j * m)) / determinante;
                inverse[3, 1] = (a * (j * o - k * n) - b * (i * o - k * m) + c * (i * n - j * m)) / determinante;
                inverse[3, 2] = -(a * (f * o - g * n) - b * (e * o - g * m) + c * (e * n - f * m)) / determinante;
                inverse[3, 3] = (a * (f * k - g * j) - b * (e * k - g * i) + c * (e * j - f * i)) / determinante;


                Console.WriteLine("Inverse Matrix:");
                for (int Spalte = 0; Spalte < 4; Spalte++)
                {
                    for (int Zeile = 0; Zeile < 4; Zeile++)
                    {
                        Console.Write(" {0:F5} \t", inverse[Spalte, Zeile]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
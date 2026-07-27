using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[7];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Zahl " + (i + 1) + " eingeben: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minIndex = i;
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"Die größte Zahl ist {max} mit dem Index {maxIndex}.");
        Console.WriteLine($"Die kleinste Zahl ist {min} mit dem Index {minIndex}.");
        Console.ReadKey();
    }
}
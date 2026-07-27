using System;
using System.Runtime.CompilerServices;

public class MyCar
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Speed { get; set; }

    public MyCar(string make, string model, int year, double speed)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Speed = speed;
    }

    public void accelerate(double amount)
    {
        Speed += amount;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Mark: {Make}, Model: {Model}, Year: {Year}, Speed: {Speed}");
    }

    public void brake()
    {
        for (int i = 0; i < Speed && i >= 0; i++)
        {
            Console.WriteLine(Speed -= i);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCar car = new MyCar("Toyota", "Carolla", 2020, 60.0);
        car.DisplayDetails();

        car.accelerate(20.5);
        car.DisplayDetails();

        car.brake();
        car.DisplayDetails();
    }
}
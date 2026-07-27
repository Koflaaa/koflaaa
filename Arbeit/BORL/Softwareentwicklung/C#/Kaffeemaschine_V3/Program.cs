class CoffeeMachine
{
    private int waterSupply; // Vorrat an Wasser in Millilitern
    private int coffeeBeansSupply; // Vorrat an Kaffeebohnen in Gramm
    private int milkSupply; // Vorrat an Milch in Millilitern
    private double insertedmoneh; // Eingeworfenes Geld in Euro

    public CoffeeMachine(int water, int coffeeBeans, int milk)
    {// Erstellen eines Konstruktors
        this.waterSupply = water;
        this.coffeeBeansSupply = coffeeBeans;
        this.milkSupply = milk;
    }

    public void RefillWater(int amount)
    {// Erstellung Methode zur Auffüllung von Wasser
        waterSupply += amount;
        Console.WriteLine($"Wasser aufgefüllt. Neuer Wasserstand: {waterSupply} ml");
    }

    public void RefillCoffeeBeans(int amount)
    {// Erstellung Methode zur Auffüllung von Kaffeebohnen
        coffeeBeansSupply += amount;
        Console.WriteLine($"Kaffeebohnen aufgefüllt. Neuer Vorrat: {coffeeBeansSupply} g");
    }

    public void RefillMilk(int amount)
    {   // Erstellung Methode zur Auffüllung von Milch
        milkSupply += amount;
        Console.WriteLine($"Milch aufgefüllt. Neuer Vorrat: {milkSupply} ml");
    }

    public void GetVorräte()
    {   // Erstellung Methode zum Prüfen der Vorräte
        Console.WriteLine($"Vorhandene Vorräte:\nMilch: {milkSupply}\nKaffeebohnen: {milkSupply}\nWater: {milkSupply}");
    }

    public void Insertmoneh(double amount)
    {// Erstellung Methode zum Einwerfen von Geld
        insertedmoneh += amount;
        Console.WriteLine($"Eingeworfenes Geld: {insertedmoneh} Euro");
    }

    public void MakeCappuccino()
    {   //  Erstellung Methode zum Herstellen Cappuccino
        if (waterSupply < 100 || coffeeBeansSupply < 20 || milkSupply < 50)
        {// Prüfen ob genug Vorräte vorhanden sind
            Console.WriteLine("Nicht genug Zutaten für Cappuccino.");
            return;
        }

        if (insertedmoneh < 2.5)
        {// Prüfen ob zuwenig Geld eingeworfen wurde
            Console.WriteLine("Nicht genug Geld eingeworfen für Cappuccino.");
            return;
        }
        //  Abrechnen von verwendeten Ressourcen
        waterSupply -= 100;
        coffeeBeansSupply -= 20;
        milkSupply -= 50;
        insertedmoneh -= 2.5;
        Console.WriteLine("Cappuccino zubereitet. Bitte entnehmen Sie Ihr Getränk.");
    }

    public void MakeLatte()
    {   // Erstellung Methode zum Herstellen Latte
        // Prüfen ob genug Vorräte vorhanden sind
        if (waterSupply < 150 || coffeeBeansSupply < 30 || milkSupply < 100)
        {
            Console.WriteLine("Nicht genug Zutaten für Latte.");
            return;
        }
        // Prüfen ob zuwenig Geld eingeworfen wurde
        if (insertedmoneh < 3.0)
        {
            Console.WriteLine("Nicht genug Geld eingeworfen für Latte.");
            return;
        }
        // Abrechnen von verwendeten Ressourcen
        waterSupply -= 150;
        coffeeBeansSupply -= 30;
        milkSupply -= 100;
        insertedmoneh -= 3.0;
        Console.WriteLine("Latte zubereitet. Bitte entnehmen Sie Ihr Getränk.");
    }

    public void MakeEspresso()
    {
        if (waterSupply < 50 || coffeeBeansSupply < 10)
        {
            Console.WriteLine("Nicht genug Zutaten für Espresso.");
            return;
        }
        if (insertedmoneh < 1.5)
        {
            Console.WriteLine("Nicht genug Geld eingeworfen für Espresso.");
            return;
        }

        waterSupply -= 50;
        coffeeBeansSupply -= 10;
        insertedmoneh -= 1.5;
        Console.WriteLine("Espresso zubereitet. Bitte entnehmen Sie Ihr Getränk.");
    }

    public double GetInsertedmoneh()
    {
        return insertedmoneh;
    }
}

class Program
{
    static void Main()
    {
        CoffeeMachine machine = new(1000, 500, 500);            // Setzten der Standartwerte der Variablen bei Erstellung des Objekts
        double moneh;                                           // Erstellen der Variable für Eingabe von Geld
        bool running = true;                                    // Erstellen der Variable für while-Schleife
        string choice, choice2, choice3;                        // Erstellen der Variablen für spätere Eingaben

        while (running)
        {   // Verfügbare Optionen ausgeben und weiter verwerten

            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Wird gestartet . . .");
            Thread.Sleep(2000);
            Console.WriteLine("\nWillkommen!");
            Console.WriteLine("1. Getränk bestellen\n2. Vorräte auffüllen\n3. Geldstand abrufen\n4. Vorräte abrufen\n5. Exit\n");
            Console.WriteLine("Bitte wählen Sie eine dieser Optionen! | 1 | 2 | 3 | 4 | 5 | ");
            Console.Write("Auswahl: ");
            choice = Console.ReadLine();

            // Abfragen durch switch-case
            switch (choice)
            {
                case "1":
                    // Auswahl Getränke
                    Console.WriteLine("1. Latte | 2. Espresso | 3. Cappuccino");
                    Console.WriteLine("Welches Getränk möchten Sie bestellen?");

                    Console.Write("Auswahl: ");
                    choice2 = Console.ReadLine();

                    switch (choice2)
                    {   // Weitere Optionen für Getränke
                        case "1":
                            Console.Write("Ein Latte kostet 3 Euro, bitte werfen Sie Geld ein: ");
                            if (double.TryParse(Console.ReadLine(), out moneh))
                            {
                                machine.Insertmoneh(moneh);
                                Console.WriteLine("Getränk wird zubereitet . . . ");
                                Console.WriteLine("Restgeld wird ausgegeben . . . ");
                                Thread.Sleep(1000);
                                machine.MakeLatte();
                            }
                            else
                            {
                                Console.WriteLine("Ungültiger Geldbetrag.");
                            }
                            break;
                        case "2":
                            Console.Write("Ein Espresso kostet 1,50 Euro, bitte werfen Sie Geld ein: ");
                            if (double.TryParse(Console.ReadLine(), out moneh))
                            {
                                machine.Insertmoneh(moneh);
                                Console.WriteLine("Getränk wird zubereitet . . . ");
                                Console.WriteLine("Restgeld wird ausgegeben . . . ");
                                Thread.Sleep(1000);
                                machine.MakeEspresso();
                            }
                            else
                            {
                                Console.WriteLine("Ungültiger Geldbetrag.");
                            }
                            break;
                        case "3":
                            Console.Write("Ein Cappuccino kostet 2,50 Euro, bitte werfen Sie Geld ein: ");
                            if (double.TryParse(Console.ReadLine(), out moneh))
                            {
                                machine.Insertmoneh(moneh);
                                Console.WriteLine("Getränk wird zubereitet . . . ");
                                Console.WriteLine("Restgeld wird ausgegeben . . . ");
                                Thread.Sleep(1000);
                                machine.MakeCappuccino();
                            }
                            else
                            {
                                Console.WriteLine("Ungültiger Geldbetrag.");
                            }
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl.");
                            break;
                    }
                    break;
                case "2":
                    //  Auffüllen von Ressourcen
                    Console.WriteLine("1. Milch | 2. Kaffeebohnen | 3. Wasser");
                    Console.WriteLine("Welche Vorräte möchten Sie auffüllen?");

                    choice3 = Console.ReadLine();

                    switch (choice3)
                    {
                        case "1":
                            Console.WriteLine("Wie viel Milch möchten Sie nachfüllen?");
                            if (int.TryParse(Console.ReadLine(), out int milk))
                            {
                                Console.WriteLine("Wird befüllt . . .");
                                Thread.Sleep(1500);
                                machine.RefillMilk(milk);
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für Milchmenge.");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Wie viel Kaffeebohnen möchten Sie nachfüllen?");
                            if (int.TryParse(Console.ReadLine(), out int beans))
                            {
                                Console.WriteLine("Wird befüllt . . .");
                                Thread.Sleep(1500);
                                machine.RefillCoffeeBeans(beans);
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für Kaffeebohnenmenge.");
                            }
                            break;
                        case "3":
                            Console.WriteLine("Wie viel Wasser möchten Sie hinzu geben?");
                            if (int.TryParse(Console.ReadLine(), out int water))
                            {
                                Console.WriteLine("Wird befüllt . . .");
                                Thread.Sleep(1500);
                                machine.RefillWater(water);
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für Wassermenge.");
                            }
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl für Vorrat.");
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Geldstand wird geprüft . . . ");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Eingeworfenes Geld: {machine.GetInsertedmoneh()} Euro");
                    break;
                case "4":
                    Console.WriteLine("Vorräte werden geprüft . . . ");
                    Thread.Sleep(1000);
                    machine.GetVorräte();
                    break;
                case "5":
                    Console.WriteLine("Wird beendet . . . ");
                    Thread.Sleep(1000);
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Geben Sie bitte eine gültige Option ein.");
                    break;
            }
        }
    }
}

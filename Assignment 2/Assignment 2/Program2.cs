using System;

class Vehicle
{
    public string Make;
    public string Model;
    public int Year;
}

class Truck : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Make}, {Model}, {Year}");
    }
}

class Bus : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Bus: {Make}, {Model}, {Year}");
    }
}

class Program2
{
    static void Main()
    {
        Truck t = new Truck();
        t.Make = "Tata";
        t.Model = "LPT 1613";
        t.Year = 2020;
        t.DisplayDetails();

        Bus b = new Bus();
        b.Make = "Volvo";
        b.Model = "9400XL";
        b.Year = 2022;
        b.DisplayDetails();
    }
}

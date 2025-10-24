using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
}

class Program3
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        Console.WriteLine("Add(float, float): " + calc.Add(5.5f, 4.5f));
        Console.WriteLine("Add(double, double, double): " + calc.Add(1.1, 2.2, 3.3));
    }
}

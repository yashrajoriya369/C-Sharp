using System;

abstract class Employee
{
    public string Name;
    public int Id;
    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary;

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class PartTimeEmployee : Employee
{
    public double HourlyRate;
    public int HoursWorked;

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

class Program4
{
    static void Main()
    {
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.Name = "Rahul";
        fte.Id = 1;
        fte.MonthlySalary = 50000;
        Console.WriteLine($"Full Time Employee Salary: {fte.CalculateSalary()}");

        PartTimeEmployee pte = new PartTimeEmployee();
        pte.Name = "Amit";
        pte.Id = 2;
        pte.HourlyRate = 200;
        pte.HoursWorked = 50;
        Console.WriteLine($"Part Time Employee Salary: {pte.CalculateSalary()}");
    }
}

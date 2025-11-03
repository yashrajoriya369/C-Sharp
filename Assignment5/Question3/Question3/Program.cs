using System;

class NegativeSalaryException : Exception
{
    public NegativeSalaryException(string message)
    : base(message)
    {
    }
}

class Program
{
    static void CheckSalary(int num)
    {
        if (num < 0)
        {
            // Throw user-defined exception
            throw new NegativeSalaryException("Salary cannot be negative!");
        }
        else
        {
            Console.WriteLine("Salary is valid: " + num);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter your Salary: ");
            int n = Convert.ToInt32(Console.ReadLine()); CheckSalary(n);
        }
        catch (NegativeSalaryException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution Completed.");
        }
    }
}

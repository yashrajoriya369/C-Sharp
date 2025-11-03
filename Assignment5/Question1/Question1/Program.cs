using System;

public class NumberDivision
{
    public static void Main(string[] args)
    {
        try
        {
            int num = 10; int den = 0;
            int result = num / den; Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero is not allowed." + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}

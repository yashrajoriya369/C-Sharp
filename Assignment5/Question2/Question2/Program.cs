using System;

public class NumberFormation
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Number: " + num);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Enter a valid number.");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow Occured: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error Occured: " + ex.Message);
        }
    }
}

using System;

class InvalidMarksException : Exception
{
    public InvalidMarksException(string message)
    : base(message)
    {
    }
}

class Program
{
    static void SubjectMarks(int marks)
    {
        if (marks < 0 || marks > 100)
        {
            // Throw user-defined exception
            throw new InvalidMarksException("Invalid marrks.");
        }
        else
        {
            Console.WriteLine("Valid marks: " + marks);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter your marks: ");
            int n = Convert.ToInt32(Console.ReadLine()); SubjectMarks(n);
        }
        catch (InvalidMarksException ex)
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

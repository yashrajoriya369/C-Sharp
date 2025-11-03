using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
    : base(message)
    {
    }
}

class Program
{
    static void Balance(int withdrawal)
    {
        int balance = 2000;
        if (withdrawal > balance)
        {
            // Throw user-defined exception
            throw new InsufficientBalanceException("Balance is Insufficient.");
        }
        else
        {
            Console.WriteLine("Credited & Remaining Balance: " + (balance - withdrawal));
        }
    }
    static void Main()
    {
        try
        {
            Console.Write("Enter Withdrawal Amount: "); int n = Convert.ToInt32(Console.ReadLine()); Balance(n);
        }
        catch (InsufficientBalanceException ex)
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

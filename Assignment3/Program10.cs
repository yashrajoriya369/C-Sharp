//10.Design a class BankAccount with properties like AccountNumber and Balance. Implement a sealed
//class SavingsAccount that extends BankAccount with methods for interest calculation.

using System;

namespace Assignment3
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            SavingsAccount mySavings = new SavingsAccount("SA12345", 1000.0, 0.05);
            mySavings.DisplayAccountDetails();
            mySavings.CalculateInterest();
            mySavings.DisplayAccountDetails();
        }
    }
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
    public sealed class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; } // e.g., 0.05 for 5%
        public SavingsAccount(string accountNumber, double initialBalance, double interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void CalculateInterest()
        {
            double interest = Balance * InterestRate;
            Deposit(interest);
            Console.WriteLine("Interest of " + interest + " added to the account.");
        }
    }
}
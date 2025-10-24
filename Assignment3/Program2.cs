// 2. Create a class called BankAccount with properties for account number, account holder name, and
// balance.Implement methods for deposit, withdrawal, and displaying the account details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.account_number = 123456;
            account.account_holder_name = "Rahul Agrawal";
            account.balance = 1000.0;
            account.DisplayAccountDetails();
            account.Deposit(500.0);
            account.Withdraw(200.0);
            account.DisplayAccountDetails();
            account.Withdraw(1500.0); // Attempting to withdraw more than the balance
        }
    }

    public class BankAccount
    {
        public int account_number;
        public string account_holder_name;
        public double balance;
    public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + account_number);
            Console.WriteLine("Account Holder Name: " + account_holder_name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine();
        }
    }
}

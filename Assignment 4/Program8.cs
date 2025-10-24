//Q8.Create a delegate BillingOperation that accepts a product amount.
//• Implement four related methods:
//1. ShowTotal → Display original price.
//2. ApplyDiscount → Apply 10% discount.
//3.4. FinalBill → Display final payable amount.
//• Use delegate chaining to call these methods step by step for an item worth ₹5000.

using System;

namespace Assignment_4
{
    public delegate void BillingOperation(decimal amount);
    internal class Program8
    {
        public static void ShowTotal(decimal amount)
        {
            Console.WriteLine($"Original Price: ₹{amount}");
        }
        public static void ApplyDiscount(decimal amount)
        {
            decimal discount = amount * 0.10m;
            amount -= discount;
            Console.WriteLine($"Discount Applied: ₹{discount}");
            FinalBill(amount);
        }
        public static void FinalBill(decimal amount)
        {
            Console.WriteLine($"Final Payable Amount: ₹{amount}");
        }
        static void Main(string[] args)
        {
            BillingOperation billingOperation = ShowTotal;
            billingOperation += ApplyDiscount;
            decimal productAmount = 5000m;
            billingOperation(productAmount);
            Console.ReadLine();
        }
    }
}
//Q6.Define a delegate Operation for performing arithmetic operations.
//• Implement methods Add and Subtract.
//• Ask the user for two numbers and apply both operations using the delegate.

using System;

namespace Assignment_4
{
    public delegate int Operation(int a, int b);
    internal class Program6
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Operation operation = Add;
            int sum = operation(num1, num2);
            Console.WriteLine($"Sum: {sum}");
            operation = Subtract;
            int difference = operation(num1, num2);
            Console.WriteLine($"Difference: {difference}");
            Console.ReadLine();
        }
    }
}
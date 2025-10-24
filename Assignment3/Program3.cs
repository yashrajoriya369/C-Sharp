//3.Create a static utility class named MathHelper with a static method CalculateAverage that takes an
//array of integers as input and returns their average.

using System;
namespace Assignment3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = MathHelper.CalculateAverage(numbers);
            Console.WriteLine("The average is: " + average);
        }
    }
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}
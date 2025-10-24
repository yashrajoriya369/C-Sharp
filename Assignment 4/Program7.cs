//Q7.Create a delegate FormatText that accepts a string.
//• Implement methods to return:
//1. The string in uppercase.
//2. The string in lowercase.
//• Demonstrate calling both through the delegate on input "Hello World".

using System;

namespace Assignment_4
{
    public delegate string FormatText(string input);
    internal class Program7
    {
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }
        public static string ToLowerCase(string input)
        {
            return input.ToLower();
        }
        static void Main(string[] args)
        {
            FormatText formatText = ToUpperCase;
            string upper = formatText("Hello World");
            Console.WriteLine($"Uppercase: {upper}");
            formatText = ToLowerCase;
            string lower = formatText("Hello World");
            Console.WriteLine($"Lowercase: {lower}");
            Console.ReadLine();
        }
    }
}
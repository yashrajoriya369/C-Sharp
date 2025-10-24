//Q9.Define a delegate ConvertTemperature that takes double input.
//• Implement two methods:
//1. Celsius to Fahrenheit.
//2. Celsius to Kelvin.
//• Show result for 25°C.

using System;
namespace Assignment_4
{
    public delegate double ConvertTemperature(double celsius);
    internal class Program9
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        static void Main(string[] args)
        {
            ConvertTemperature toFahrenheit = CelsiusToFahrenheit;
            ConvertTemperature toKelvin = CelsiusToKelvin;
            double celsius = 25.0;
            double fahrenheit = toFahrenheit(celsius);
            double kelvin = toKelvin(celsius);
            Console.WriteLine($"{celsius}°C in Fahrenheit: {fahrenheit}°F");
            Console.WriteLine($"{celsius}°C in Kelvin: {kelvin}K");
            Console.ReadLine();
        }
    }
}
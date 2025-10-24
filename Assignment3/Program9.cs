//9.Create a base class Vehicle with methods like StartEngine and StopEngine. Derive a class Car from
//Vehicle and seal it.Try to create a class that inherits from Car and observe the behavior.

using System;

namespace Assignment3
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.StartEngine();
            myCar.StopEngine();
        }
    }
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
    public sealed class Car : Vehicle
    {
        // Car specific implementations can go here
    }
    // The following class will cause a compile-time error because Car is sealed
    /*
    public class SportsCar : Car
    {
        // This will not compile
    }
    */
}
//7.Define an abstract base class Shape with an abstract method CalculateArea.Derive classes like Circle
//and Rectangle from Shape and implement the area calculation methods for each.

using System;

namespace Assignment3
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
        }
    }
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
}
// 1. Create a class called Employee with properties for name, age, and salary. Implement a method to
//display employee details.
using System;
using System.Xml.Linq;

namespace Assignment3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Yash Rajoriya";
            emp.age = 23;
            emp.salary = 80000.0f;
            Employee emp1 = new Employee();
            emp1.name = "Yash Raj";
            emp1.age = 21;
            emp1.salary = 70000.0f;
            emp.Display();
            emp1.Display();

        }
    }

    public class Employee
    {
        
        public string name;
        public int age;
        public double salary;

        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine();
        }

    }


}

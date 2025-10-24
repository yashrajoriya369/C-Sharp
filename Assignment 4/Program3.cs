//Q3.Create a class Employee with:
//• A private field basicSalary.
//• A read-only property TotalSalary that calculates salary with 20% bonus.
//• Demonstrate setting basicSalary = 30000 and display TotalSalary.


using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Employee
    {
        private decimal basicSalary;
        public decimal BasicSalary
        {
            set { basicSalary = value; }
        }
        public decimal TotalSalary
        {
            get { return basicSalary + (basicSalary * 0.20m); }
        }
    }
    internal class Program3
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.BasicSalary = 30000;
            Console.WriteLine($"Total Salary (with 20% bonus) for Basic Salary 30000: {employee.TotalSalary}");
            Console.ReadLine();
        }
    }
}
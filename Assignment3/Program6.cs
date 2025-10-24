//6.Create a partial class Employee with properties representing employee details. In another part,
//implement methods for calculating salary based on different factors.

using System;

namespace Assignment3
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeID = 101;
            employee.Name = "Alice Smith";
            employee.BasicSalary = 50000;
            double grossSalary = employee.CalculateGrossSalary(10000, 5000);
            Console.WriteLine("Gross Salary of " + employee.Name + " (ID: " + employee.EmployeeID + ") is: " + grossSalary);
        }
    }
}

   public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
    }
    public partial class Employee
    {
        public double CalculateGrossSalary(double allowances, double deductions)
        {
            return BasicSalary + allowances - deductions;
        }
    }
}
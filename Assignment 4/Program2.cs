//Q2.Design a class Student with a property Age.
//• Ensure that only values between 5 and 25 are allowed.
//• If invalid age is set, default to 18.
//• Show the behavior for age 4, 20, and 30.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Student
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 25)
                {
                    age = value;
                }
                else
                {
                    age = 18;
                }
            }
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Age = 4;
            Console.WriteLine($"Student 1 Age (set to 4): {student1.Age}");
            Student student2 = new Student();
            student2.Age = 20;
            Console.WriteLine($"Student 2 Age (set to 20): {student2.Age}");
            Student student3 = new Student();
            student3.Age = 30;
            Console.WriteLine($"Student 3 Age (set to 30): {student3.Age}");
            Console.ReadLine();
        }
    }
}

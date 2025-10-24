//5.Define a partial class Person with one part containing properties like FirstName and LastName, and
//another part with methods like PrintFullName to display the full name. Implement these parts in
//separate files.

using System;
namespace Assignment3
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.PrintFullName();
        }
    }
}
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public partial class Person
    {
        public void PrintFullName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
    }
}

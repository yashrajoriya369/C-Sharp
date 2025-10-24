//8.Design an abstract class Animal with properties like Name and Age. Derive classes like Dog and Cat
//from Animal with their unique methods.

using System;

namespace Assignment3
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Buddy", 3);
            Animal cat = new Cat("Whiskers", 2);
            dog.MakeSound();
            cat.MakeSound();
        }
    }
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Woof Woof!");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Meow Meow!");
        }
    }
}
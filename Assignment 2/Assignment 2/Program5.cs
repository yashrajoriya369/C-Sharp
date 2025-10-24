using System;

class Student
{
    public string Name;
    public int RollNo;
    public double Marks;

    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        Marks = 0.0;
    }

    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
        Marks = 0.0;
    }

    public Student(string name, int rollNo, double marks)
    {
        Name = name;
        RollNo = rollNo;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}, Marks: {Marks}");
    }
}

class Program5
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student("Rahul", 101);
        Student s3 = new Student("Amit", 102, 88.5);

        s1.Display();
        s2.Display();
        s3.Display();
    }
}

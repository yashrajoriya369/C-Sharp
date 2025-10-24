using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public bool IsAvailable = true;

    public void DisplayBook()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Available: {IsAvailable}");
    }
}

class Member
{
    public string Name;
    public int MemberID;
}

class Library
{
    public List<Book> Books = new List<Book>();
    public List<Member> Members = new List<Member>();

    public void RegisterMember(Member m)
    {
        Members.Add(m);
        Console.WriteLine($"Member '{m.Name}' registered.");
    }

    public void AddBook(Book b)
    {
        Books.Add(b);
        Console.WriteLine($"Book '{b.Title}' added.");
    }

    public void LendBook(string title, Member m)
    {
        foreach (var book in Books)
        {
            if (book.Title == title && book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"Book '{title}' lent to {m.Name}.");
                return;
            }
        }
        Console.WriteLine("Book not available.");
    }
}

class Program7
{
    static void Main()
    {
        Library lib = new Library();

        Book b1 = new Book() { Title = "C# Basics", Author = "John" };
        Book b2 = new Book() { Title = "Java Programming", Author = "Smith" };
        lib.AddBook(b1);
        lib.AddBook(b2);

        Member m1 = new Member() { Name = "Rahul", MemberID = 1 };
        lib.RegisterMember(m1);

        lib.LendBook("C# Basics", m1);
        lib.LendBook("C# Basics", m1); // already lent

        Console.WriteLine("\nAvailable Books:");
        foreach (var book in lib.Books)
        {
            book.DisplayBook();
        }
    }
}

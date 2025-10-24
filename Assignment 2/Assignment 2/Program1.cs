using System;

class UserProfile
{
    private string username;
    private string password;
    private string email;

    public void SetUsername(string uname)
    {
        username = uname;
    }

    public string GetUsername()
    {
        return username;
    }

    public void SetPassword(string pwd)
    {
        if (pwd.Length >= 6)
        {
            password = pwd;
        }
        else
        {
            Console.WriteLine("Password must be at least 6 characters long.");
        }
    }

    public string GetPassword()
    {
        return password;
    }

    public void SetEmail(string mail)
    {
        if (mail.Contains("@"))
        {
            email = mail;
        }
        else
        {
            Console.WriteLine("Invalid Email.");
        }
    }

    public string GetEmail()
    {
        return email;
    }
}

class Program1
{
    static void Main()
    {
        UserProfile user1 = new UserProfile();
        user1.SetUsername("Rahul");
        user1.SetPassword("12345"); // invalid
        user1.SetPassword("123456"); // valid
        user1.SetEmail("rahulgmail.com"); // invalid
        user1.SetEmail("rahul@gmail.com"); // valid

        Console.WriteLine("Username: " + user1.GetUsername());
        Console.WriteLine("Password: " + user1.GetPassword());
        Console.WriteLine("Email: " + user1.GetEmail());

        UserProfile user2 = new UserProfile();
        user2.SetUsername("Amit");
        user2.SetPassword("abcdef");
        user2.SetEmail("amit@example.com");

        Console.WriteLine("\nUsername: " + user2.GetUsername());
        Console.WriteLine("Password: " + user2.GetPassword());
        Console.WriteLine("Email: " + user2.GetEmail());
    }
}

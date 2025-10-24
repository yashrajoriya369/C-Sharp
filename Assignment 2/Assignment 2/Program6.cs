using System;

class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }

    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative!");
        }
    }

    public int Quantity { get; set; }

    public void DisplayProduct()
    {
        Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
    }
}

class Program6
{
    static void Main()
    {
        Product p1 = new Product();
        p1.ProductID = 1;
        p1.ProductName = "Laptop";
        p1.Price = 55000;
        p1.Quantity = 5;
        p1.DisplayProduct();

        Product p2 = new Product();
        p2.ProductID = 2;
        p2.ProductName = "Mouse";
        p2.Price = -500; // invalid
        p2.Quantity = 10;
        p2.DisplayProduct();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    public class Customer
    {
        public string Name;
        public string Address;
        public string PhoneNumber;
    }

    public class  Product
    {
        public string Title;
        public decimal Price;
        public int Quantity;
        public string Warranty;
    }

    public class Seller
    {
        public string Name;
        public string Address;
        public string PhoneNumber;
    }
    class Invoice
    {
        public string InvoiceNumber;
        public string OrderId;
        public string OrderDate;
        public string InvoiceDate;
        public Customer Buyer;
        public Seller SellerInfo;
        public List<Product> Products = new List<Product>();
        public double TotalAmount = 0;

        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalAmount += (double)(product.Price * product.Quantity);
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Invoice Number: " + InvoiceNumber);
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Invoice Date: " + InvoiceDate);
            Console.WriteLine("\nSeller Information:");
            Console.WriteLine("Name: " + SellerInfo.Name);
            Console.WriteLine("Address: " + SellerInfo.Address);
            Console.WriteLine("Phone Number: " + SellerInfo.PhoneNumber);
            Console.WriteLine("\nBuyer Information:");
            Console.WriteLine("Name: " + Buyer.Name);
            Console.WriteLine("Address: " + Buyer.Address);
            Console.WriteLine("Phone Number: " + Buyer.PhoneNumber);
            Console.WriteLine("\nProducts:");
            foreach (var product in Products)
            {
                Console.WriteLine($"Title: {product.Title}, Price: {product.Price}, Quantity: {product.Quantity}, Warranty: {product.Warranty}");
            }
            Console.WriteLine($"\nTotal Amount: {TotalAmount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Rahul Agrawal";
            customer.Address = "Near ***** ****** ****** Mathura";
            customer.PhoneNumber = "555-1234";
            Seller seller = new Seller();
            seller.Name = "Best Buy";
            seller.Address = "Dampier Nagar Mathura";
            seller.PhoneNumber = "555-5678";
            Invoice invoice = new Invoice();
            invoice.InvoiceNumber = "INV-1001";
            invoice.OrderId = "ORD-2002";
            invoice.OrderDate = "2025-08-27";
            invoice.InvoiceDate = "2025-08-28";
            invoice.Buyer = customer;
            invoice.SellerInfo = seller;
            Product product1 = new Product();
            product1.Title = "Laptop";
            product1.Price = 999.99m;
            product1.Quantity = 1;
            product1.Warranty = "2 years";
            invoice.AddProduct(product1);
            Product product2 = new Product();
            product2.Title = "Smartphone";
            product2.Price = 499.99m;
            product2.Quantity = 2;
            product2.Warranty = "1 year";
            invoice.AddProduct(product2);
            invoice.PrintInvoice();
            Console.ReadLine();
        }
    }
}

//Q4.Build a class Product with two auto-properties: Price and Discount.
//• Add a method to calculate the final price = Price – (Price * Discount/100).
//• Show result for a product with Price = 2000 and Discount = 10%.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Product
    {
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice()
        {
            return Price - (Price * Discount / 100);
        }
    }
    internal class Program4
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Price = 2000;
            product.Discount = 10;
            Console.WriteLine($"Final Price for Product with Price 2000 and Discount 10%: {product.FinalPrice()}");
            Console.ReadLine();
        }
    }
}
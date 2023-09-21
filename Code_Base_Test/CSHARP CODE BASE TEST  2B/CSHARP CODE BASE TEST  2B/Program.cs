using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_CODE_BASE_TEST__2B
{
    class Products
    {
        int Productid;
        string ProductName;
        double Price;

        public Products(int productid, string productname, double price)
        {
            Productid = productid;
            ProductName = productname;
            Price = price;
        }
    

        static void Main(string[] args)
        {
        List<Products> products = new List<Products>();
        for (int i=1;i<=10; i++)
        {
            Console.WriteLine("enter product details");
            Console.WriteLine("enter product id");
            int Productid = int.Parse(Console.ReadLine());
            Console.Write("Product Name: ");
            string ProductName = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
             products.Add(new Products(Productid, ProductName, price));
            products.Sort((n1, n2) => n1.Price.CompareTo(n2.Price));
            Console.WriteLine("  Sorted Products by Price:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.Productid}, Product Name: {product.ProductName}, Price: {product.Price}");
            }
        }
        Console.WriteLine("");
            Console.ReadLine();
        }
        }
    }


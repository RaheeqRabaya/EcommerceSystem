using System;
using System.Collections.Generic;
using System.Globalization;
using ECommerceSystem.BusinessLayer.Managers.Impl;
using ECommerceSystem.DataLayer.Entities;
using ECommerceSystem.DataLayer.Enums;
using ECommerceSystem.DataLayer.Repository.Impl;

namespace ECommerceSystem.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            ProductRepository repo = new ProductRepository();
            List<Product> products = repo.LoadProducts();

            if (products.Count == 0)
            {
                products = new List<Product>
                {
                    new Product { ID = 1, Name = "Laptop", Price = 999.99 },
                    new Product { ID = 2, Name = "Phone", Price = 499.99 },
                    new Product { ID = 3, Name = "Tablet", Price = 299.99 }
                };

                repo.SaveProducts(products);
                Console.WriteLine("Sample products saved.");
            }

           
            Console.WriteLine("\nAvailable Products:");
            foreach (var p in products)
            {
                Console.WriteLine(p.GetProductInfo());
            }

            
            var customer = new Customer(1, "Raheeq");
            customer.Cart.AddProduct(products[0]);
            customer.Cart.AddProduct(products[1]);

            
            Console.WriteLine("\nCart:");
            foreach (var p in customer.Cart.Products)
            {
                Console.WriteLine(p.GetProductInfo());
            }

          
            var order = customer.PlaceOrder();
            double total = order.ApplyDiscount(10);
            Console.WriteLine($"\nTotal after 10% discount: {total:C}");

             
            var payment = new Payment();
            if (payment.ProcessPayment(total))
            {
                order.Status = OrderStatus.Processing;
                Console.WriteLine($"Order Status: {order.Status}");
            }
            else
            {
                Console.WriteLine("Payment failed.");
            }

            Console.WriteLine("\nThank you for shopping!");
        }
    }
}

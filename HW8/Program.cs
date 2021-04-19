using System;
using System.Collections.Generic;

namespace shop
{
    internal partial class Program
    {
        private static readonly List<Product> _products = new List<Product>();
        private static decimal _money = 50;
        static void Main(string[] args)
        {
            Product product = new Product();
            Manager manager = new Manager();
            Customer customer = new Customer();

            ChooseAction(manager, product, customer);
        }

        static void ChooseAction(Manager manager, Product product, Customer customer)
        {
            var action = "";

            while (action?.ToLower() != "e")
            {
                Console.WriteLine("Our shop welcoms you! Are you manager (m) or customer (c) or exit (e)?");
                action = Console.ReadLine();
                switch (action?.ToLower())
                {
                    case "m":
                        while (action != "e")
                        {
                            Console.WriteLine("Do you want to show (s), add (a), delete (d) products or exit (e)?");
                            action = Console.ReadLine();
                            switch (action?.ToLower())
                            {
                                case "s": product.ShowProducts(); break;
                                case "a": manager.AddProducts(); break;
                                case "d": manager.DeleteProducts(); break;
                                default: Console.WriteLine($"Invalid operation {action}."); break;
                            }
                        }
                        break;
                    case "c":
                        while (action != "e")
                        {
                            Console.WriteLine("Do you want to show (s) products  or exit (e)?");
                            action = Console.ReadLine();
                            switch (action?.ToLower())
                            {
                                case "s":
                                    product.ShowProducts();
                                    while (action != "e")
                                    {
                                        Console.WriteLine("Do you want to buy (b) products  or exit (e)?");
                                        action = Console.ReadLine();
                                        switch (action?.ToLower())
                                        {
                                            case "b": customer.BuyProducts(); break;
                                            default: Console.WriteLine($"Invalid operation {action}"); break;
                                        }
                                    }
                                    break;
                                default: Console.WriteLine($"Invalid operation {action}"); break;
                            }
                        }
                        break;
                    default: Console.WriteLine($"Invalid operation {action}"); break;
                }
            }
        }
    }
}
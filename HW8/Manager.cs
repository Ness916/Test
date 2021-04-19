using System;

namespace shop
{
    internal partial class Program
    {
        public class Manager
        {
            public void ShowProducts(Product product)
            {
                product.ShowProducts();
            }

            public void AddProducts()
            {
                Console.WriteLine("Please write the name of the product you want to add");
                var productName = Console.ReadLine();
                productName = productName.ToLower();
                Console.WriteLine("Please write the price of the product");
                var productPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Please write the quantity of the product");
                var productQuantity = int.Parse(Console.ReadLine());

                _products.Add(new Product() { name = productName, price = productPrice, quantity = productQuantity });

                Console.WriteLine($"Product {productName} {productPrice} {productQuantity} was added successfully ");
            }

            public void DeleteProducts()
            {
                Console.WriteLine("Please write the name of the product you want to delete");
                var productName = Console.ReadLine();
                productName = productName.ToLower();

                if (_products.Remove(_products.Find(r => r.name == productName)))
                    Console.WriteLine($"Product {productName} was delete successfully ");
                else
                    Console.WriteLine($"Product {productName} is not exist");
            }

        }
    }
}
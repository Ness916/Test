using System;

namespace shop
{
    internal partial class Program
    {
        public class Product
        {
            public string name { get; set; }
            public decimal? price { get; set; }
            public int quantity { get; set; }
            public void ShowProducts()
            {
                //Добавление элементов в список
                _products.Add(new Product() { name = "Milk", price = 1, quantity = 10 });
                _products.Add(new Product() { name = "Bread", price = 2, quantity = 3 });
                _products.Add(new Product() { name = "Ice-cream", price = 5, quantity = 5 });
                _products.Add(new Product() { name = "Coffee", price = 2, quantity = 5 });
                _products.Add(new Product() { name = "Tea", price = 1, quantity = 0 });
                _products.Add(new Product() { name = "Sore-cream", price = 2, quantity = 5 });
                _products.Add(new Product() { name = "Chicken", price = 20, quantity = 7 });
                _products.Add(new Product() { name = "Salmon", price = 30, quantity = 100 });

                foreach (Product product in _products)
                {
                    Console.WriteLine($"Name: {product.name}, Price: {product.price}, Quantity: {product.quantity}");
                }
            }
        }
    }
}
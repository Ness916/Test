using System;

namespace shop
{
    internal partial class Program
    {
        public class Customer
        {
            public void ShowProducts(Product product)
            {
                product.ShowProducts();
            }

            public void BuyProducts()
            {
                Console.WriteLine($"I have $ {_money} to buy products");
                Console.WriteLine("Please write the name of the product you want to buy");
                var productName = Console.ReadLine();
                productName = productName.ToLower();
                var isProductExist = false;
                Console.WriteLine($"Please write the quantity of the {productName} ");
                var quantityOfItem = int.Parse(Console.ReadLine());

                foreach (Product product in _products)
                {
                    if (product.name?.ToLower() == productName)
                    {
                        isProductExist = true;
                        if ((product.quantity>= quantityOfItem)&& (quantityOfItem>0))
                        {
                            if (_money >= (product.price*quantityOfItem))
                            {
                                product.quantity = product.quantity - quantityOfItem;
                                _money = _money - Convert.ToDecimal(product.price)*quantityOfItem;
                                Console.WriteLine($"You bought the product {product.name} for the price {product.price}. You have $ {_money} left");
                            }
                            else
                            {
                                Console.WriteLine($"Product: {productName} {quantityOfItem} items costs {product.price * quantityOfItem}  you have {_money}");
                            }
                        }
                        else
                            Console.WriteLine($"Unfortunately, this quantity of {productName} is out of stock ");
                    }
                }
                if (isProductExist)
                {
                    Console.WriteLine($"There is no such product: {productName} in the stock");
                }
            }

        }
    }
}
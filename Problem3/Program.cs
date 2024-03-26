using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, (decimal price, int quantity)> products = new Dictionary<string, (decimal price, int quantity)>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "buy")
                break;

            string[] productInfo = input.Split();
            string name = productInfo[0];
            decimal price = decimal.Parse(productInfo[1]);
            int quantity = int.Parse(productInfo[2]);

            if (products.ContainsKey(name))
            {
                
                products[name] = (price, products[name].quantity + quantity);
            }
            else
            {
                
                products.Add(name, (price, quantity));
            }
        }

       
        foreach (var product in products)
        {
            string productName = product.Key;
            decimal totalPrice = product.Value.price * product.Value.quantity;
            Console.WriteLine($"{productName} -> {totalPrice:F2}");
        }
    }
}

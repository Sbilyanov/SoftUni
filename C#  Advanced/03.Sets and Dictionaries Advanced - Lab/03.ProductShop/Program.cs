using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopList = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input!="Revision")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shopList.ContainsKey(shop))
                {
                    shopList.Add(shop, new Dictionary<string, double>());
                }
                if (!shopList[shop].ContainsKey(product))
                {
                    shopList[shop].Add(product,price);
                }
 
                input = Console.ReadLine();
            }

            foreach (var shop in shopList.OrderBy(n=>n.Key))
            {
                Console.WriteLine(shop.Key+"->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value }");
                }
            }
        }
    }
}

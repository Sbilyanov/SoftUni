using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while (command!="buy")
            {
                string[] input = command.Split();
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<double> { productPrice, quantity });
                }
                else
                {
                    products[productName][0] = productPrice;
                    products[productName][1] += quantity;
                }
                    command = Console.ReadLine();
                
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }

        }
    }
}

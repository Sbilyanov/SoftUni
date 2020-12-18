using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfProducts
{
    class ListOfProducts
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }
                products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                output.AppendLine($"{i + 1}.{products[i]}");
            }
            Console.WriteLine(output); 
        }
    }
}

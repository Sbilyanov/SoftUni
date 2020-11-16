using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(input))
                {
                    resources.Add(input,0);
                }

                resources[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

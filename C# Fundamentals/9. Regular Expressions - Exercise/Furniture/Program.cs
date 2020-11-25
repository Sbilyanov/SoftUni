using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            double moneySpend = 0;

            Console.WriteLine("Bought furniture:");

            while (input!= "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    Console.WriteLine(name);
                    moneySpend += price * quantity;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {moneySpend:f2}");

        }
    }
}

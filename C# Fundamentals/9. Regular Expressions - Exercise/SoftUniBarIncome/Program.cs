using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";

            Regex regex = new Regex(pattern);
            double income = 0;

            string input = Console.ReadLine();
            
            while (input!= "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {



                    string customerName = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int total = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    double totalPrice = total * price;
                    income += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: { income:f2}");
        }
    }
}

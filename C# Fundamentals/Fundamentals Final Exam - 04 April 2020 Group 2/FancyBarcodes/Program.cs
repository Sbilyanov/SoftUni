using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]@\#+";
            string patternNum = @"(\d+)";
            Regex productPattern = new Regex(pattern);
            Regex groupPattern = new Regex(patternNum);

            int productCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productCount; i++)
            {
                string input = Console.ReadLine();
                Match match = productPattern.Match(input);
                if (match.Success)
                {
                    var pro = match.ToString();

                    MatchCollection group = groupPattern.Matches(pro);
                    if (group.Count > 0)
                    {

                        var product = String.Concat(group);
                        Console.WriteLine($"Product group: {product}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}

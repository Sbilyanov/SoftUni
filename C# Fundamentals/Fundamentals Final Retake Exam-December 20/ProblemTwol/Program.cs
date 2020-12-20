using System;
using System.Text.RegularExpressions;

namespace ProblemTwol
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|([A-Z]{4,})\|:#([a-zA-Z]+ [a-zA-Z]+)#";
            Regex regPattern = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regPattern.Match(input);
                string bossName = string.Empty;
                string title = string.Empty;
                if (match.Success)
                {
                     bossName = match.Groups[1].ToString();
                     title = match.Groups[2].ToString();
                    Console.WriteLine($"{ bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");

                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
 
            }


        }
    }
}

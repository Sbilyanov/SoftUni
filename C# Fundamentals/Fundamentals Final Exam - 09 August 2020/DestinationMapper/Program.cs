using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = string pattern = @"(\*|@)([A-Za-z]{3,})\1:[[:space:]](\[\w\])\|(\[\w\])\|(\[\w\])\|";
            Regex regPatter = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection matches = regPatter.Matches(input);
            List<string> cities = new List<string>(); 
           
            int points = 0;

            if (matches.Count > 0)
            {


                foreach (Match match in matches)
                {
                    points += match.Groups[2].Length;                   
                    cities.Add(match.Groups[2].ToString());

                }
            }

            Console.WriteLine($"Destinations: {string.Join(", ",cities)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}

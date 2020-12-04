using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(\w+\s*\w+)\1(\d{2}\/(\d{2})\/\d{2})\1(\d+)\1";
            Regex regexPattern = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection foods = regexPattern.Matches(input);
            int totalcal= 0;
            int dayliLimit = 2000;

            if (foods.Count > 0)
            {
                int dayCount = 1;
                foreach (Match calories in foods)
                { 
                     totalcal+= int.Parse(calories.Groups[5].Value);

                
                }
                Console.WriteLine($"You have food to last you for: {totalcal/dayliLimit} days!");
                foreach (Match food in foods)
                {
                    Console.WriteLine($"Item: {food.Groups[2]}, Best before: {food.Groups[3]}, Nutrition: {food.Groups[5]}");
                }
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!") ;
            }
        }
    }
}

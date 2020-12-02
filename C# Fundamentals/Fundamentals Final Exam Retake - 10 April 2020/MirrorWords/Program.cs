using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\#|\@])(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";
            Regex wordPattern = new Regex(pattern);

            string input = Console.ReadLine();
            List<string> mirrorWords = new List<string>(); 
         
            MatchCollection matches = wordPattern.Matches(input);

            if (matches.Count <= 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {

                        var first = match.Groups[2].ToString();
                        var second = match.Groups[3].ToString();
                        var reverseSecond = String.Concat(second.Reverse());

                        if (first == reverseSecond)
                        {

                            mirrorWords.Add(first + " <=> " + second);
                        }
                    }
                }

                    Console.WriteLine($"{matches.Count} word pairs found!");
                
            }
    
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine($"{string.Join(", ",mirrorWords)}");
            }

        }
    }
}

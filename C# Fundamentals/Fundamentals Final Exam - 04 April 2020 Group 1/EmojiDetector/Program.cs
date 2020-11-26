using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"[\d]";
            string emojiPattern = @"(::|\*\*)([A-Z][a-z]{2,})\1";

            Regex numReg = new Regex(numberPattern);

            string input = Console.ReadLine();

            MatchCollection matches = numReg.Matches(input);

            long coolThresholdSum = 1;

            for (int i = 0; i < matches.Count; i++)
            {
                coolThresholdSum *= int.Parse(matches[i].ToString());
            }


            /*
           matches.Select(c => c.Value)
                .Select(int.Parse)
                .ToList()
                .Select(c => coolThresholdSum *= c);
            */

            Regex emojisPatt = new Regex(emojiPattern);
            MatchCollection matchEmoji = emojisPatt.Matches(input);
            List<string> coolEmojis = new List<string>();

           

            foreach (Match item in matchEmoji)
            {
                long coolEmojiValue = item.Value
                     .Substring(2, item.Length - 4)
                     .ToCharArray()
                     .Sum(c => (int)c);


                if (coolEmojiValue>=coolThresholdSum)
                {
                    coolEmojis.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matchEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        



        }
    }
}

using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (var element in letters)
            {
                if (element!=' ')
                {
                    if (!occurrences.ContainsKey(element))
                    {
                        occurrences.Add(element,0);
                    }
                    occurrences[element]++;
                }
            }
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

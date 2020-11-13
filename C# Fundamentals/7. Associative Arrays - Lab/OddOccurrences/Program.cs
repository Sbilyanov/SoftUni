using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }

            }
            foreach (var item in words)
            {
                if (item.Value%2!=0)
                {
                    Console.Write(item.Key +" "  );
                }
            }
        }
    }
}

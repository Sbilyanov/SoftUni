using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] words= File.ReadAllLines("words.txt");

            string filePath = Path.Combine("..", "..", "..", "actualResult.txt");

            Dictionary<string, int> wordsList = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsList.Add(word.ToLower(),0);
            }

            string[] text = File.ReadAllText("input.txt").ToLower()
                    .Split(new[] { "-", " ", ",", ".", "!", "?", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in text)
            {
                if (wordsList.ContainsKey(word))
                {
                    wordsList[word]++;
                }
            }

            Dictionary<string, int> sortedWords = wordsList.OrderByDescending(v=>v.Value)
                        .ToDictionary(k=>k.Key,v=>v.Value);

          
            string[] expectedWords = File.ReadAllLines("expectedResult.txt");


            List<string> expectedResult = new List<string>();
            foreach (var item in expectedWords)
            {
                expectedResult.Add(item);
            }

            List<string> outputLines = sortedWords.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();

            if (expectedResult.SequenceEqual(outputLines))
            {
                File.WriteAllLines(filePath, outputLines);

            }
            else
            {
              
                File.WriteAllText(filePath, "Try again");
            }


            

        }
    }
}

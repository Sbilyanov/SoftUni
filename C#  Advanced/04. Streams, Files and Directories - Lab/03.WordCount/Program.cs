using System;
using System.Collections.Generic;
using System.IO;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamReader readerWords = new StreamReader("../../../words.txt"))
                {
                    string[] words = readerWords.ReadLine().Split();

                    string[] text = reader.ReadToEnd().
                        Split(new[] { " ", ",", ".", "!", "?", "-",Environment.NewLine },StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        int counter = 1;
                        for (int j = 0; j < text.Length; j++)
                        {

                            if (words[i] == text[j])
                            {
                              
                                if (!result.ContainsKey(words[i]))
                                {
                                    result.Add(words[i], counter);
                                }
                                result[words[i]]++;
                            }
                        }
                        using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                        {
                            writer.WriteLine($"{words[i]} - {counter}");
                        }

                    }

                }


            }
        }
    }
}

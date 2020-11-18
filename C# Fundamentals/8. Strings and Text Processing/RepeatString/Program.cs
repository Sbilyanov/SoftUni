using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string output = string.Empty;

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    output += word;

                }

            }
            Console.WriteLine(output);
        }
    }
}

using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string outputPath = Path.Combine("..", "..", "..", "output.txt");

            int lineCounter = 1;

            foreach (string words in lines)
            {

                int punctuationCounter = 0;
                int letterCounter = 0;

               
                foreach (char ch in words)
                {
                    if (char.IsLetter(ch))
                    {
                        letterCounter++;
                    }
                    else if (char.IsPunctuation(ch))
                    {
                        punctuationCounter++;
                    }

                }

                string output = $"Line {lineCounter}: {words}({letterCounter})({punctuationCounter})";
       
                File.AppendAllText(outputPath, output + Environment.NewLine);
            }
        }
    }
}

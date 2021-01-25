using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentLine = reader.ReadLine();
                int row = 1;
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (currentLine!=null)
                    {
                        writer.WriteLine($"{row}. {currentLine}");

                        row++;

                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}

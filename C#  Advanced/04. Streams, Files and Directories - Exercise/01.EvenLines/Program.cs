using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader =new StreamReader("input.txt"))
            {
               using StreamWriter writer = new StreamWriter("output.txt");

                string line = reader.ReadLine();
                string pattern = @"[-,.!?]";

                int counter = 0;

                while (line != null)
                {
                    if (counter++ % 2 == 0)
                    {
                        string replaced = Regex.Replace(line, pattern, "@");

                        string[] output = replaced.Split();

                        writer.WriteLine(string.Join(' ', output.Reverse()));
                    }

                    line = reader.ReadLine();
                }

            }
        }
    }
}

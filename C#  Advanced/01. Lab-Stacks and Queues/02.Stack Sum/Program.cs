using System;
using System.Collections.Generic;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> elements = new Stack<string>(input);

            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (token[0].ToUpper())
                {
                    case "ADD":
                        for (int i = 1; i < token.Length; i++)
                        {
                            elements.Push(token[i]);
                        }
                        break;
                    case "REMOVE":
                        if (elements.Count >= int.Parse(token[1]))
                        {
                            for (int i = 0; i < int.Parse(token[1]); i++)
                            {
                                elements.Pop();
                            }
                        }

                        break;
                }
                command = Console.ReadLine();

            }
            int sum = 0;
            foreach (var item in elements)
            {
                int currentElement = int.Parse(item);
                sum += currentElement; 

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

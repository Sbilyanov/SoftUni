using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationsCount = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            Stack<string> history = new Stack<string>();

            for (int i = 0; i < operationsCount; i++)
            {


                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        text = text.Append(tokens[1]);
                        history.Push(text.ToString());
                        break;
                    case 2:
                        int eraseCharsCount = int.Parse(tokens[1]);
                        text = text.Remove(text.Length - eraseCharsCount, eraseCharsCount);
                        history.Push(text.ToString());
                        break;
                    case 3:
                        int charIndex = int.Parse(tokens[1])-1;
                        Console.WriteLine(text.ToString().ToCharArray()[charIndex]);
                        break;
                    case 4:
                        if (history.Count > 1)
                        {
                            history.Pop();
                            text = text.Clear();
                            text = text.Append(history.Peek());
                        }
                        else if (history.Count == 1)
                        {
                            history.Pop();
                            text = text.Clear();
                        }
                        break;

                }
            }
        }
    }
}

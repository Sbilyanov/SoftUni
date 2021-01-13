using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> numberStack = new Stack<string>(input);

            while (numberStack.Count > 1)
            {
                int leftNumber = int.Parse(numberStack.Pop());
                string sing = numberStack.Pop();
                int rightNumber = int.Parse(numberStack.Pop());
                int result = 0;
                if (sing == "+")
                {
                    result = leftNumber + rightNumber;
                }
                else if (sing == "-")
                {
                    result = leftNumber - rightNumber;
                }
                numberStack.Push(result.ToString());

            }
            Console.WriteLine(numberStack.Pop());

        }
    }
}

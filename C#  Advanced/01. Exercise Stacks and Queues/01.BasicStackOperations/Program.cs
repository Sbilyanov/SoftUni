using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stackElements = new Stack<int>();
            int minNumber = int.MaxValue;

            for (int i = 0; i < input[0]; i++)
            {
                stackElements.Push(elements[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                stackElements.Pop();
            }
            if (stackElements.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stackElements.Count>0)
                {
                    foreach (var item in stackElements)
                    {
                        if (item<=minNumber)
                        {
                            minNumber = item;
                        }
                    }
                    Console.WriteLine(minNumber);

                }
                else
                {
                    Console.WriteLine(0);
                }
               
            }
        }
    }
}

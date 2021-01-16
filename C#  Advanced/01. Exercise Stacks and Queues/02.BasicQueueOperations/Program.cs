using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueElements = new Queue<int>();
            int minNumber = int.MaxValue;

            for (int i = 0; i < input[0]; i++)
            {
                queueElements.Enqueue(elements[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                queueElements.Dequeue();
            }
            if (queueElements.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queueElements.Count > 0)
                {
                    foreach (var item in queueElements)
                    {
                        if (item <= minNumber)
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

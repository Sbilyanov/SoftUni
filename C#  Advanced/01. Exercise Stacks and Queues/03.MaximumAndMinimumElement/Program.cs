using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackOfNumbers = new Stack<int>();
            int queries = int.Parse(Console.ReadLine());
            int minElement = int.MaxValue;
            int maxElement = int.MinValue;

            for (int i = 0; i < queries; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        stackOfNumbers.Push(command[1]);
                        break;
                    case 2:
                        stackOfNumbers.Pop();
                        break;
                    case 3:
                        if (stackOfNumbers.Count > 0)
                        {
                            foreach (var item in stackOfNumbers)
                            {
                                if (item >= maxElement)
                                {
                                    maxElement = item;
                                }
                            }
                            Console.WriteLine(maxElement);
                        }
                        break;
                    case 4:
                        if (stackOfNumbers.Count > 0)
                        {
                            foreach (var item in stackOfNumbers)
                            {
                                if (item <= minElement)
                                {
                                    minElement = item;
                                }
                            }
                            Console.WriteLine(minElement);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stackOfNumbers));
        }
    }
}

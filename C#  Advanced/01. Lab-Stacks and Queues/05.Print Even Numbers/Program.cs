using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>(input.Where(x => x % 2 == 0).ToList());

            while (evenNumbers.Count>1)
            {
                Console.Write(evenNumbers.Dequeue()+", ");
            }
            Console.WriteLine(evenNumbers.Dequeue());
        }
    }
}

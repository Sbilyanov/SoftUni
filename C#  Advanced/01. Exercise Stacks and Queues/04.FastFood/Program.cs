using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());

            int[] ordes = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> ordersQueue = new Queue<int>(ordes);
            int biggesOrder = ordersQueue.Max();
            Console.WriteLine(biggesOrder);

            while (ordersQueue.Any())
            {
               int currentOrder=ordersQueue.Peek();
                if (total-currentOrder<0)
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', ordersQueue)}");
                    return;
                }
                total -= currentOrder;
                ordersQueue.Dequeue();
               
            }
            Console.WriteLine("Orders complete");
        }
    }
}

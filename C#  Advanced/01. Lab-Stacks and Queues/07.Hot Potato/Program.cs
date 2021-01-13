using System;
using System.Collections.Generic;

namespace _07.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int number = int.Parse(Console.ReadLine());
            Queue<string> childens = new Queue<string>(input);
            int potatoTosses = 0;
            while (childens.Count > 1)
            {
                potatoTosses++;
                string kid = childens.Dequeue();
                if (potatoTosses == number)
                {
                    potatoTosses = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    childens.Enqueue(kid);
                }

            }
            Console.WriteLine($"Last is {childens.Dequeue()}");


        }
    }
}

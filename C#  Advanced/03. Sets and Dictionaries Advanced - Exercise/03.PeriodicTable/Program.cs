using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int j = 0; j < n; j++)
            {
               string[]input=Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i++)
                {
                    elements.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(' ',elements));
        }
    }
}

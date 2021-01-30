using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int, bool> predicate = (num, div) => num % div == 0;

            for (int i = 1; i <= end; i++)
            {
                if (dividers.All(div=>predicate(i,div)))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}

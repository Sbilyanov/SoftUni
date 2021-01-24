using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> fristSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < n[0]; i++)
            {
                fristSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            fristSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ",fristSet));
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            if (numbers.Count<5)
            {
                Console.WriteLine("No");
                return;

            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            double average = numbers.Average();

            var result = numbers.OrderByDescending(x => x).Where(x => x > average).Take(5)

            Console.WriteLine(string.Join(' ',result));
           
        }
    }
}

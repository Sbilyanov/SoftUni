using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(n=>n+(n*0.2m)).ToArray();
            foreach (var price in array)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}

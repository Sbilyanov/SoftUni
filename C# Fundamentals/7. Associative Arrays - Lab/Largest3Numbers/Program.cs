using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers= Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();
            int count = numbers.Length >= 3 ? 3:numbers.Length;


            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            
            
        }
    }
}

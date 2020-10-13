using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();

            numbers.Reverse();

            List<string> result = new List<string>();

            foreach (string items in numbers)
            {
                string[] array = items.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string index in array)
                {
                    result.Add(index);

                }


            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}

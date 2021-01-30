using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(name=>$"Sir {name}").ToList();

            Action<List<string>> printing = n => Console.WriteLine(string.Join(Environment.NewLine,n));

            printing(input);
        }
    }
}

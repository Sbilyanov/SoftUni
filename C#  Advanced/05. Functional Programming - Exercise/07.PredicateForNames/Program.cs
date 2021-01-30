using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            // Predicate<string> predicate = name => name.Length <= n;
            // List<string> sortedNames = names.Where(n=>predicate(n)).ToList();  

            Func<string, int, bool> func = (name, length) => name.Length <= length;
            List<string> sortedNames = names.Where(names=>func(names,n)).ToList();  
            
            Action<List<string>> print = n => Console.WriteLine(string.Join(Environment.NewLine,n));
            print(sortedNames);
        }
    }
}

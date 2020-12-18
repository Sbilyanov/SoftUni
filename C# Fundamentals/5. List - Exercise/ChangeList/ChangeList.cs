using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "DELETE":
                        numbers.RemoveAll(x=>x==int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
             command = Console.ReadLine()
                .Split()
                .ToArray();

            }
            Console.WriteLine(string.Join(' ' ,numbers));


        }
        
    }
}

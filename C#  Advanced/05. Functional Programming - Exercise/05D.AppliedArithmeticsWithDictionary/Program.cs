using System;
using System.Collections.Generic;
using System.Linq;

namespace _05D.AppliedArithmeticsWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            Action<List<int>> print = n => Console.WriteLine(string.Join(' ', n));

            Dictionary<string, Func<int, int>> arithmeticDictionary =new Dictionary<string, Func<int, int>>()
            {
                { "add", x => x + 1 },
                { "subtract", x => x - 1 },
                { "multiply", x => x * 2 }
             };

            while (command != "end")
            {
                if (arithmeticDictionary.ContainsKey(command))
                {
                    numbers = numbers.Select(arithmeticDictionary[command]).ToList();
                }


                else if (command == "print")
                {
                    print(numbers);
                }
              

                command = Console.ReadLine();
            }


        }
    }
}


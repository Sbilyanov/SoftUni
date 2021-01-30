using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Action<List<int>> print = n => Console.WriteLine(string.Join(' ', n));
            while (command != "end")
            {
                if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    //numbers.Select(n=>arithmeticFunc(n)).ToList();
                    Func<int, int> arithmeticFunc = GetAritmeticFunc(command);
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }

                command = Console.ReadLine();
            }


        }

        private static Func<int, int> GetAritmeticFunc(string command)
        {
            switch (command)
            {
                case "add": return x => x + 1;
                case "subtract": return x => x - 1;
                case "multiply": return x => x * 2;
                default: return null;

            }
        }
    }
}

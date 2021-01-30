using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printing = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            printing(input);
        }
    }
}

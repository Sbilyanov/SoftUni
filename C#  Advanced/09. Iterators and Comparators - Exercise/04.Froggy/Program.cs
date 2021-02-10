using System;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake<int> stones = new Lake<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Console.WriteLine(string.Join(", ",stones));
        }
    }
}

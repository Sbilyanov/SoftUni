using System;

namespace ConcatNames
{
    class ConcatNames
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string thrid = Console.ReadLine();

            Console.WriteLine($"{first}{thrid}{second}");
        }
    }
}

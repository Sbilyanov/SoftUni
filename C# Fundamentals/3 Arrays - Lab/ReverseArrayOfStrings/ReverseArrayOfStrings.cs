using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(' ',Console.ReadLine()
                .Split()
                .Reverse()));

        }
    }
}

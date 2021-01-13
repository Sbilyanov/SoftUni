using System;
using System.Collections.Generic;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseWord = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverseWord.Push(input[i]);
            }
            while (reverseWord.Count>0)
            {
                Console.Write(reverseWord.Pop());
            }
        }
    }
}

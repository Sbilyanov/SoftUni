using System;
using System.Collections.Generic;

namespace _04.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine();
            Stack<int> barcketSIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    
                    barcketSIndex.Push(i);
                }
                if (input[i]==')')
                {
                    int startIndex = barcketSIndex.Pop();
                    Console.WriteLine(input.Substring(startIndex,i-startIndex+1));
                }
                
            }

        }
    }
}

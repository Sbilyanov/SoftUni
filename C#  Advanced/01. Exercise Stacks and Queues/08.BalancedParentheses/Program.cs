using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stackBarckets = new Stack<char>();
            

            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stackBarckets.Push(item);
                }
                else
                {
                    if (stackBarckets.Count > 0)
                    {
                        if (item == ')' && stackBarckets.Pop() != '('
                            || item == '}' && stackBarckets.Pop() != '{'
                            || item == ']' && stackBarckets.Pop() != '[')
                        {

                            Console.WriteLine("NO");
                            return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }
            Console.WriteLine("YES");


        }
    }
}

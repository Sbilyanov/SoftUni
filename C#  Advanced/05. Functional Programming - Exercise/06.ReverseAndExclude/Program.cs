using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> ReverseFunc = MyReverse(input);
            Action<List<int>> print = n => Console.WriteLine(string.Join(' ',n));
            Func<int,bool> predicate = p => p % n != 0;
            

            input=ReverseFunc(input);

            //input = MyWhere(input, predicate);
             print(MyWhere(input,predicate));
        }

        private static Func<List<int>,List<int>> MyReverse(List<int> input)
        {
            List<int> reverse = new List<int>();
            for (int i = input.Count-1; i >= 0; i--)
            {
                reverse.Add(input[i]);
            }
            return x=>x=reverse;
        }
        static List<int> MyWhere(List<int>input,Func<int,bool>predicate)
        {
            List<int> sortedNum = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (predicate(input[i]))
                {
                    sortedNum.Add(input[i]);
                }

            }
            return sortedNum;
        }
    }
}

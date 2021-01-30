using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string condition = Console.ReadLine();
            int start = input[0];
            int end = input[1];
            List<int> numbers = new List<int>();

          //  Func<int, int, List<int>> generateNumbers = (s, e) => Enumerable.Range(start, end).ToList();
           Func<int, int, List<int>> generateNumbers = (s,e) =>
              {
                  List<int> num = new List<int>();
                  for (int i = start; i <= end; i++)
                  {
                      num.Add(i);
                  }
                  return num;
              };

            numbers = generateNumbers(start, end);

            Predicate<int> predicate = n => true;

            if (condition=="even")
            {
                predicate = n => n % 2 == 0;
            }
            else if (condition=="odd")
            {
                predicate = n => n % 2 != 0;
            }
            Console.WriteLine(string.Join(" ",MyWhere(numbers,predicate)));
           
        }
        static List<int> MyWhere (List<int>numbers,Predicate<int>predicate)
        {
            List<int> sortedNum = new List<int>(); 
             foreach (var num in numbers)
            {
                if (predicate(num))
                {
                    sortedNum.Add(num);
                }
            }
            return sortedNum;
        }
    }
}

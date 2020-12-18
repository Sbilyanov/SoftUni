using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {

                
                if (numbers[i]==bombNumbers[0])
                {
                    int startInex = i - bombNumbers[1];
                    int endIndex = i + bombNumbers[1];

                    if (startInex<0)
                    {
                        startInex = 0;
                    }
                    if (endIndex>numbers.Count-1)
                    {
                        endIndex = numbers.Count-1;
                    }

                    int endIndexToRemove = endIndex-startInex+1;

                    numbers.RemoveRange(startInex, endIndexToRemove);

                    i = startInex - 1;
                }
               

            }
            Console.WriteLine(numbers.Sum()) ;
        }
    }
}

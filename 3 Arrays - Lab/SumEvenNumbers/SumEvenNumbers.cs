using System;
using System.Linq;

namespace SumEvenNumbers
{
    class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                
                if (number[i] %2 ==0)
                {
                    result += number[i];
                }

            }
            Console.WriteLine(result);
        }
    }
}

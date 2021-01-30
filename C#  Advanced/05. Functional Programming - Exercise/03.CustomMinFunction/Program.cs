using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> customMin = n =>
             {
                 int min = int.MaxValue;
                 for (int i = 0; i < numbers.Length; i++)
                 {
                     if (numbers[i] < min)
                     {
                         min = numbers[i];
                     }
                 }
                 return min;
             };

            Console.WriteLine(customMin(numbers));
        }
    }
}

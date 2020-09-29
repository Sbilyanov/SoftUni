using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var evenSum = 0;
            var oddSum = 0;


            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    evenSum += number[i];
                }
                else
                {
                    oddSum += number[i];
                }

            }
            Console.WriteLine($"{evenSum-oddSum}");




        }
    }
}

﻿using System;

namespace ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 1; i <=input; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }

}


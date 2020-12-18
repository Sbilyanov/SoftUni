﻿using System;
using System.Linq;

namespace MagicSum
{
    class MagicSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int result = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == result)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                        break;
                    }


                }
            }

        }
    }
}

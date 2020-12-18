using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            bool isBigger = true;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]>=currentNum)
                    {
                        isBigger= false;
                        break;
                    }

                }
                if (isBigger)
                {
                    Console.Write(currentNum+" ");
                }
                isBigger = true;
            }

        }
    }
}

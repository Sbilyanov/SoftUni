using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int maxSequence = 0;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;

                    }
                    else
                    {
                        break;
                    }
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        maxIndex = array[i];
                    }

                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(maxIndex + " ");

            }
        }
    }
}

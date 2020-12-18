using System;
using System.Linq;

namespace EqualArrays
{
    class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int result = 0;

            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] != secondLine[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;

                }
                else if(firstLine[i] == secondLine[i])
                {
                    result += firstLine[i]; 
                }


            }
            Console.WriteLine($"Arrays are identical. Sum: {result}");



        }
    }
}

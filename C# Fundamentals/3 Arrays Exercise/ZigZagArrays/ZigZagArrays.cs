using System;
using System.Linq;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] evenArray = new string[n];
            string[] oddArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (i % 2 == 0)
                {
                    evenArray[i] = array[0];
                    oddArray[i] = array[1];

                }
                else
                {
                    evenArray[i] = array[1];
                    oddArray[i] = array[0];
                }

            }
            Console.WriteLine(string.Join(' ', evenArray));
            Console.WriteLine(string.Join(' ', oddArray));

        }
    }
}

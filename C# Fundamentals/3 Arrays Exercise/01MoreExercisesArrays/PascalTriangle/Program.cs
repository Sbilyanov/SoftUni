using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] previous = new int[] { 1 };

            Console.WriteLine(1);
            for (int i = 2; i <= input; i++)
            {
                int[] values = new int[i];
                values[0] = 1;
                values[i - 1] = 1;
                for (int j = 1; j <i-1; j++)
                {
                    values[j] = previous[j - 1] + previous[j];

                }
                Console.WriteLine(string.Join(' ',values));
                previous = values;
            }
        }
    }
}

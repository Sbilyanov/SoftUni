using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();
            int[] rounds = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rounds[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(arr[i])} => {Convert.ToDecimal(rounds[i])}");
            }
        }
    }

}

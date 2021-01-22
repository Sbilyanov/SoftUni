using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> valuesCount = new Dictionary<double, int>();
          

                for (int j = 0; j < input.Length; j++)
                {
                    if (!valuesCount.ContainsKey(input[j]))
                    {
                    valuesCount.Add(input[j], 0);
                    }

                valuesCount[input[j]]++;
                }

            
            foreach (var item in valuesCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

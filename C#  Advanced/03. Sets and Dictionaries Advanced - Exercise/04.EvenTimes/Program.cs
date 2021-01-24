using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> numbers = new Dictionary<int, int>();
           

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }
                numbers[currentNumber]++;

            }
                  numbers= numbers.Where(n => n.Value % 2 == 0).ToDictionary(k=>k.Key,v=>v.Value);
            Console.WriteLine(string.Join(' ',numbers.Keys));
        }
    }
}

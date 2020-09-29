using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
         



            for (int i = 0; i <num.Length-1; i++)
            {
                for (int j = 0; j < num.Length-1; j++)
                {
                    num[j] = num[j] + num[j + 1];

                }
     
            }
            Console.WriteLine(num[0]);
           
        }
    }
}

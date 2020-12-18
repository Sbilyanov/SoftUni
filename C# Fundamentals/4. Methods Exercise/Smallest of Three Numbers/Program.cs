using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)     
        {

        int minValue = int.MaxValue;
           
            PrintMinValue(minValue);
           
        }

        private static void PrintMinValue(int minValue)
        {

            for (int i = 0; i < 3; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum <= minValue)
                {
                    minValue = currentNum;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}

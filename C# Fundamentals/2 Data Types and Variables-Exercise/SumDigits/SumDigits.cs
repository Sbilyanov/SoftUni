using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int digitSum = 0;
            while (input>0)
            {
                digitSum += input % 10;
                input = input / 10;
            }
            Console.WriteLine(digitSum);
        }
    }
}

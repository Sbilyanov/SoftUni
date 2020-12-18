using System;

namespace PoundsToDollars
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            double pounds= double.Parse(Console.ReadLine());
            decimal dollars= (decimal)(pounds * 1.31); 

            Console.WriteLine($"{dollars:F3}");
        }
    }
}

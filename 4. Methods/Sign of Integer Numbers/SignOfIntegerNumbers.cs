using System;

namespace Sign_of_Integer_Numbers
{
    class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            printNumberSign(number);
        }
        static void printNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine( $"The number { number} is negative." );
            }
            else if (number> 0)
            {
                Console.WriteLine($"The number { number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number { number} is zero.");
            }

        }
    }
}
 
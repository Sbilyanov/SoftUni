using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double garde = double.Parse(Console.ReadLine());

            if (garde>=3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine( "Failed!" );
            }
        }
    }
}

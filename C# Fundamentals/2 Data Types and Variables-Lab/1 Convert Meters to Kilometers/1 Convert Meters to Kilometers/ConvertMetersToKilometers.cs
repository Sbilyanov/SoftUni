using System;

namespace _1_Convert_Meters_to_Kilometers
{
    class ConvertMetersToKilometers
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}

using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "WV";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make:{car.Make} Model:{car.Model} Year:{car.Year}");
        }
    }
}

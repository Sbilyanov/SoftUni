using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(0);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                Cargo cargo = new Cargo()
                {
                    CargoWeight = int.Parse(input[3]),
                    CargoType = input[4]
                };

                Tire[] tires = new Tire[]
                {
                    new Tire{TirePressure=double.Parse(input[5]), TireAge=int.Parse(input[6])},
                    new Tire{TirePressure=double.Parse(input[7]), TireAge=int.Parse(input[8])},
                    new Tire{TirePressure=double.Parse(input[9]), TireAge=int.Parse(input[10])},
                    new Tire{TirePressure=double.Parse(input[11]), TireAge=int.Parse(input[12])}
                };

                Car currentCar = new Car(model, engineSpeed, enginePower, cargo, tires);

                cars.Add(currentCar);
            }

            string searchedCargoType = Console.ReadLine();

            List<Car> sortedCars = new List<Car>();

            if (searchedCargoType== "fragile")
            {
                sortedCars = cars.Where(c => c.Cargo.CargoType == searchedCargoType).
                Where(t => t.Tires.Any(tp => tp.TirePressure < 1.0)).ToList();

            }
            if (searchedCargoType== "flamable")
            {
                sortedCars = cars.Where(c => c.Cargo.CargoType == searchedCargoType).
                    Where(en => en.EnginePower > 250).ToList();
            }

            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Model}");
            }

        }
    }
}

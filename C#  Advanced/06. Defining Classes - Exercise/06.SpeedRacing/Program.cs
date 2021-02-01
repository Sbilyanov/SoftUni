using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carsElements = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string model = carsElements[0];
                double fuelAmount = double.Parse(carsElements[1]);
                double fuelConsumptionFor1km = double.Parse(carsElements[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currentCar);

            }

            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                Car selectCar = cars.Find(c=>c.Model.Equals(carModel));

                selectCar.Drive(amountOfKm);

                input = Console.ReadLine();

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}

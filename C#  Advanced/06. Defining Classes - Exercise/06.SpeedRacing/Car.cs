using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    class Car
    {
        public Car( string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;

            FuelAmount = fuelAmount;

            TravelledDistance = 0;

            FuelConsumptionPerKm = fuelConsumptionFor1km;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double TravelledDistance { get; set; }

        public double FuelConsumptionPerKm { get; set; }



        public void Drive(double amountOfKm)
        {
            double fuelToConsume = amountOfKm * FuelConsumptionPerKm;

            if (FuelAmount-fuelToConsume>=0)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

    }
}

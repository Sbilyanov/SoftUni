using System;


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year =int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car fristCar = new Car();
            Car secondCar = new Car(model,make,year);
            Car thridCar = new Car(model,make,year,fuelQuantity,fuelConsumption);

           
        }
    }
}

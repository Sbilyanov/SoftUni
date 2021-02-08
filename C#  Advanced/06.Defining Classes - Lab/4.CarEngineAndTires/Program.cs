using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
                {
                    new Tire (2020, 2.3),               
                    new Tire (2020, 2.2),                
                    new Tire (2020 , 2.1),          
                    new Tire (2020 , 2.4)
                };

            Engine engine = new Engine(500, 5000);

            Car car = new Car("BMW", "M6", 2010, 100, 20, engine, tires);


            Console.WriteLine("Horse power: " + car.Engine.HorsePower);

            foreach (var tire in car.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }
        }
    }
}

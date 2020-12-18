using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command = Console.ReadLine();


            while (command!="End")
            {
                string[] elements = command.Split().ToArray();
                string type = elements[0].ToLower();
                string model = elements[1];
                string color = elements[2];
                double horsepower = double.Parse(elements[3]);

                Vehicle currentVehilcle = new Vehicle(type,model,color,horsepower);
                catalogue.Add(currentVehilcle);

                command = Console.ReadLine();
            }
            string searchVehicle = Console.ReadLine();
            while (searchVehicle!= "Close the Catalogue")
            {
                Vehicle PrintCar = catalogue.First(x => x.Model == searchVehicle);
                Console.WriteLine(PrintCar);

                searchVehicle = Console.ReadLine();
            }
            List<Vehicle> cars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = catalogue.Where(x => x.Type == "truck").ToList();
            double averageCars = 0.00;
            double averageTrucks = 0.00;
            if (cars.Count>0)
            {
                averageCars = cars.Sum(x => x.Horsepower) / cars.Count;
            }
            if (trucks.Count>0)
            {
                averageTrucks = trucks.Sum(x => x.Horsepower) / trucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
          
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type=="car" ? "Car":"Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}

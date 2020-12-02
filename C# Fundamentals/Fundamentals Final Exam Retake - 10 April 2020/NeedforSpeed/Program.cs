using System;
using System.Linq;
using System.Collections.Generic;


namespace NeedforSpeed
{
    class Cars
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
        public override string ToString()
        {
            return $"{Model}|{Mileage}|{Fuel}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfcars = int.Parse(Console.ReadLine());
            List<Cars> listOfCars = new List<Cars>();

            for (int i = 0; i < numberOfcars; i++)
            {
                string[] tokens = Console.ReadLine().Split('|');
                string model = tokens[0];
                int mileage = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);

                listOfCars.Add(new Cars { Model = model, Mileage = mileage, Fuel = fuel });

            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string currentcar = command[1];
                Cars car = listOfCars.FirstOrDefault(c => c.Model == currentcar);

                switch (command[0])
                {
                    case "Drive":
                        int distance = int.Parse(command[2]);
                        int fuel = int.Parse(command[3]);
                        if (car.Fuel >= fuel)
                        {
                            car.Mileage += distance;
                            car.Fuel -= fuel;

                            Console.WriteLine($"{car.Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (car.Mileage >= 100000)
                            {
                                listOfCars.Remove(car);
                                Console.WriteLine($"Time to sell the {car.Model}!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        break;

                    case "Refuel":
                        int refil = int.Parse(command[2]);
                        int totalRefil = 0;
                        if (car.Fuel+refil>75)
                        {
                            totalRefil = Math.Abs(((car.Fuel + refil) - 75)-refil);
                            
                        }
                        else
                        {
                            totalRefil=refil;
                        }
                        car.Fuel += totalRefil;

                        Console.WriteLine($"{car.Model} refueled with {totalRefil} liters");

                        break;

                    case "Revert":
                        int kilometers =int.Parse(command[2]);
                        car.Mileage -= kilometers;

                        if (car.Mileage<=10000)
                        {
                            car.Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car.Model} mileage decreased by {kilometers} kilometers");
                        }
                        
                        break;
                }


                input = Console.ReadLine();
            }
            foreach (var car in listOfCars.OrderByDescending(m=>m.Mileage).ThenBy(n=>n.Model))
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }

        }
    }
}

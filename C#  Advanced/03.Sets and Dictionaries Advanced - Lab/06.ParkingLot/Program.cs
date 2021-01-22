using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            HashSet<string> carsList = new HashSet<string>();

            while (input != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "IN":
                        carsList.Add(command[1]);
                        break;
                    case "OUT":
                        carsList.Remove(command[1]);
                        break;
                }

                input = Console.ReadLine();
            }
            if (carsList.Count > 0)
            {

                foreach (var car in carsList)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}

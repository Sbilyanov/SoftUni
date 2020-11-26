using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> towns = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (towns.ContainsKey(town))
                {
                    towns[town]["population"] += population;
                    towns[town]["gold"] += gold;
                }
                else
                {
                    towns.Add(town, new Dictionary<string, int>()
                    {
                        {"population",population },
                        {"gold",gold }
                    });
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();


            while (input != "End")
            {
                string[] command = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string town = command[1];

                switch (command[0])
                {
                    case "Plunder":
                        int people = int.Parse(command[2]);
                        int gold = int.Parse(command[3]);
                        towns[town]["population"] -= people;
                        towns[town]["gold"] -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (towns[town]["population"] <= 0 || towns[town]["gold"] <= 0)
                        {
                            towns.Remove(town);

                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        gold = int.Parse(command[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            if (towns.ContainsKey(town))
                            {
                                towns[town]["gold"] += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury." +
                                    $" {town} now has {towns[town]["gold"]} gold.");
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            if (towns.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

                foreach (var town in towns.OrderByDescending(g=>g.Value["gold"]).ThenBy(n=>n.Key))
                {
                    int people =town.Value["population"]; 
                   int gold=town.Value["gold"];
                    Console.WriteLine($"{town.Key} -> Population: {people} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}

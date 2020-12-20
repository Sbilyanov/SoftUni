using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heros = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string heroName = tokens[1];

                switch (command)
                {
                    case "Enroll":
                        if (heros.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        else
                        {
                            heros.Add(heroName, new List<string>());
                        }

                        break;
                    case "Learn":
                        string spell = tokens[2];
                        if (!heros.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else 
                        {
                            if (heros[heroName].Contains(spell))
                            {
                                Console.WriteLine($"{heroName} has already learnt {spell}.");
                            }
                            else
                            {
                                heros[heroName].Add(spell);
                            }
                        }
                        break;

                    case "Unlearn":
                        spell = tokens[2];

                        if (!heros.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (!heros[heroName].Contains(spell))
                            {
                                Console.WriteLine($"{heroName} doesn't know {spell}.");
                            }
                            else
                            {
                                heros[heroName].Remove(spell);
                            }

                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");
            if (heros.Values.Any(v=>v.Count !=0))
            {
                foreach (var hero in heros.OrderByDescending(v => v.Value.Count).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");

                }
            }
            else
            {
                foreach (var hero in heros.OrderBy(n=>n.Key))
                {
                    Console.WriteLine($"== {hero.Key}:");

                }

            }

        }
    }
}

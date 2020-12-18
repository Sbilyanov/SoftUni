using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
               .Split('>', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();


            int maxElementHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input!="Retire")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Fire":
                        if (int.Parse(command[1]) < 0 && int.Parse(command[1]) > warShip.Count)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        warShip[int.Parse(command[1])] -= int.Parse(command[2]);
                        for (int i = 0; i < warShip.Count; i++)
                        {
                            if (warShip[i] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;

                            }

                        }
                        break;
                    case "Defend":
                        for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                        {
                            pirateShip[i] -= int.Parse(command[3]);
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }

                        }

                        break;
                    case "Repair":
                        if (pirateShip[int.Parse(command[1])]>=maxElementHealth 
                            || int.Parse(command[1]) < 0 | int.Parse(command[1]) > pirateShip.Count)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            pirateShip[int.Parse(command[1])] += int.Parse(command[2]);
                        }

                        break;
                    case "Status":
                        int count = 0;
                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            double target = maxElementHealth * 0.20;
                            if (pirateShip[i]<target)
                            {
                                count++;
                            }

                        }
                        Console.WriteLine($"{count} sections need repair.");

                        break;

                    default:
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}

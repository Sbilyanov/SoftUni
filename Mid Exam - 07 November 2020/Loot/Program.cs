using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine()
                 .Split('|', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            List<string> stolen = new List<string>();
            string input = Console.ReadLine();
            while (input!= "Yohoho!")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Loot":
                        for (int i = 1; i < command.Count; i++)
                        {
                            if (treasure.Contains(command[i]))
                            {
                              
                                continue;
                            }

                            treasure.Insert(0, command[i]);
                        }
                        break;
                    case "Drop":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > treasure.Count)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        
                        string saveItem = treasure[int.Parse(command[1])];
                        treasure.RemoveAt(int.Parse(command[1]));
                        treasure.Add(saveItem);

                        break;
                    case "Steal":
                        treasure.Reverse();
                        stolen = treasure.Take(int.Parse(command[1])).ToList();
                        treasure.RemoveAll(item => stolen.Contains(item));
                        stolen.Reverse();
                 

                        break;
                    default:
                        break;
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", stolen));
            if (treasure.Count<=0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double total = 0;
                for (int i = 0; i < treasure.Count; i++)
                {
                    double totalLenght = treasure[i].Length;
                    total += totalLenght;
                }

                double result = total / treasure.Count;
                Console.WriteLine($"Average treasure gain: {result:f2} pirate credits.");
            }

        }
    }
}

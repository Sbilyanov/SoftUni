using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()?
                .ToUpper()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "END")
            {
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                if (index < 0 || index >= targets.Count)
                {
                    if (command[0] == "ADD") 
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if(command[0] == "STRIKE")
                    {
                        if (index-value<0||index+value>targets.Count)
                        {
                            Console.WriteLine("Strike missed!");

                        }
                  
                    }


                    command = Console.ReadLine()?
                                        .ToUpper()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                    continue;
                }


                switch (command[0])
                {
                    case "SHOOT":
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;

                    case "ADD":
                        targets.Insert(index, value);
                        break;
                    case "STRIKE":
                        if (index - value < 0 || index + value > targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            command = Console.ReadLine()?
                                       .ToUpper()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
                            continue;

                        }

                        targets.RemoveRange(index - value, value * 2 + 1);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine()?
                 .ToUpper()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }
            Console.WriteLine(string.Join('|',targets));
        }
    }
}

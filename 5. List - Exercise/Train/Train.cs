using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToUpper() != "END")
            {
                if (command[0].ToUpper() == "ADD")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passenger = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)                     
                   {
                        int n = wagons[i];

                        if ( passenger+n <= maxCapacity)
                        {
                           wagons[i]+= passenger;
                            break;

                        }
                    }
                  
                  
                }

             command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            
           
            int currentPosition = 0;

            while (command[0] != "Love!")
            {
                int jump = int.Parse(command[1]);

                currentPosition += jump;
                if (currentPosition>=0 && currentPosition<neighborhood.Count)
                {
                    neighborhood[currentPosition] -= 2;
                    
                }
                else
                {
                    currentPosition = 0;
                    neighborhood[currentPosition] -= 2;
                }
                if (neighborhood[currentPosition]==0)
                {
                    Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                }
                else if (neighborhood[currentPosition]<0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }

                command = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
            }
            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            int failedHouses = neighborhood.Count(x => x > 0);
            if (failedHouses>0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }


            
        }
    }
}

using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingList = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string userName = commands[1];
             

                switch (commands[0].ToLower())
                {
                    case "register":
                        string licensePlateNumber = commands[2];

                        if (!parkingList.ContainsKey(userName))
                        {
                            parkingList.Add(userName, licensePlateNumber);

                            Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;
                    case "unregister":

                        if (parkingList.ContainsKey(userName))
                        {
                            parkingList.Remove(userName);

                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }

            }
            foreach (var user in parkingList)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vLoggerApp =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] commandData = input.Split();
                string command = commandData[1];
                if (command == "joined")
                {
                    string vloggerName = commandData[0];
                    if (!vLoggerApp.ContainsKey(vloggerName))
                    {
                        vLoggerApp.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        vLoggerApp[vloggerName].Add("following", new SortedSet<string>());
                        vLoggerApp[vloggerName].Add("followers", new SortedSet<string>());
                     
                    }

                }
                else if (command =="followed")
                {
                    string firstVloger = commandData[0];
                    string secondVloger = commandData[2];

                    if (vLoggerApp.ContainsKey(firstVloger)
                        &&vLoggerApp.ContainsKey(secondVloger)
                        &&firstVloger!=secondVloger)
                    {

                        vLoggerApp[firstVloger]["following"].Add(secondVloger);
                        vLoggerApp[secondVloger]["followers"].Add(firstVloger);
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vLoggerApp.Count} vloggers in its logs.");

            int counter = 0;

            foreach (var vLogger in vLoggerApp.OrderByDescending(v => v.Value["followers"].Count)
                                           .ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{++counter}. {vLogger.Key} : {vLogger.Value["followers"].Count} followers," +
                    $" {vLogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var item in vLogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }  
                    
            }
        }
    }
}

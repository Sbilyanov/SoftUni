using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2

{

    class Problem3D
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mailList = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add":
                        if (!mailList.ContainsKey(command[1]))
                        {
                            mailList.Add(command[1], new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is already registered");
                        }
                        break;
                    case "Send":

                        foreach (var item in mailList)
                        {
                            if (item.Key==command[1])
                            {
                                item.Value.Add(command[2]);
                            }
                        }
                      

                        break;

                    case "Delete":
                        
                        if (mailList.ContainsKey(command[1]))
                        {
                            mailList.Remove(command[1]); 
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} not found!");
                        }
                           break;
                }
                input = Console.ReadLine();
               

            }
            Console.WriteLine($"User count:{mailList.Count}");
            foreach (var name in mailList.OrderByDescending(v => v.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{name.Key}");

                foreach (var item in name.Value)
                {
                    Console.WriteLine($"- {item}");

                }
     
            }
          

        }
    }
}

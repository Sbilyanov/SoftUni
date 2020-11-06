using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input!="Go Shopping!")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                switch (command[0])
                {
                    case "Urgent":
                        if (shopingList.Contains(command[1]))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        shopingList.Remove(command[1]);
                        shopingList.Insert(0, command[1]);
                        break;
                    case "Unnecessary":
                        if (!shopingList.Contains(command[1]))
                        {
                            input = Console.ReadLine();
                            continue;

                        }
                        shopingList.Remove(command[1]);
                        break;
                    case "Correct":
                        if (!shopingList.Contains(command[1]))
                        {
                            input = Console.ReadLine();
                            continue;

                        }
                     
                        shopingList.Insert(shopingList.IndexOf(command[1]), command[2]);
                        shopingList.Remove(command[1]);
                        break;
                    case "Rearrange":
                        if (!shopingList.Contains(command[1]))
                        {
                            input = Console.ReadLine();
                            continue;

                        }
                        shopingList.Remove(command[1]);
                        shopingList.Add(command[1]);
                        break;
                    default:
                        break;
                }
               input= Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",shopingList));
        }
    }
}

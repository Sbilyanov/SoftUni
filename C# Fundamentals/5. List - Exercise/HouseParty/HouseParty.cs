using System;
using System.Collections.Generic;
using System.Text;

namespace HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {

            int numberOfCommand = int.Parse(Console.ReadLine());
            List<string> goingNames = new List<string>();
            StringBuilder output = new StringBuilder();
            

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[2].ToUpper())
                {
                    case "GOING!":
                        if (goingNames.Contains(command[0]))
                        {
                            Console.WriteLine($"{command[0]} is already in the list!");

                        }
                        else
                        {
                            goingNames.Add(command[0]);
                        }
                        break;
                    case "NOT":
                        if (!goingNames.Contains(command[0]))
                        {
                            Console.WriteLine($"{command[0]} is not in the list!");
                        }
                        else
                        {
                            goingNames.Remove(command[0]);
                        }
               
                        break;

                }


            }
            Console.WriteLine(string.Join(Environment.NewLine, goingNames));
        }
    }
}

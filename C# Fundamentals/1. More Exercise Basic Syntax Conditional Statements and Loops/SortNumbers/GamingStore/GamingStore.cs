using System;

namespace GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalSpent = 0;
            double startingBudget = budget;

            double price = 0;

            while (input != "Game Time")
            {
                string currentGame = input;

                switch (currentGame)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:

                        Console.WriteLine("Not Found");

                        input = Console.ReadLine();

                        continue;
                }
                if (budget < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (budget >= price)
                {
                    budget -= price;
                    totalSpent += price;

                    Console.WriteLine($"Bought {currentGame}");

                    if (budget == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${startingBudget - totalSpent:f2}");
        }
    }
}

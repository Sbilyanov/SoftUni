using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string userName = Console.ReadLine();

        string input = Console.ReadLine();

        while (input != "For Azeroth")
        {
            string[] commandSplit = input.Split(" ");
            if ((commandSplit[0] != "GladiatorStance") && (commandSplit[0] != "DefensiveStance") && (commandSplit[0] != "Dispel") && (commandSplit[0] != "Target"))
            {
                Console.WriteLine("Command doesn't exist!");
            }
            if ((commandSplit[0] == "Target") && (commandSplit[1] != "Change") && (commandSplit[1] != "Remove"))
            {
                Console.WriteLine("Command doesn't exist!");
            }

            switch (commandSplit[0])
            {
                case ("GladiatorStance"):
                    userName = userName.ToUpper();
                    Console.WriteLine(userName);
                    break;
                case ("DefensiveStance"):
                    userName = userName.ToLower();
                    Console.WriteLine(userName);
                    break;
                case ("Dispel"):
                    int index = int.Parse(commandSplit[1]);
                    char letter = char.Parse(commandSplit[2]);
                    if ((index < 0) || (index >= userName.Length))
                    {
                        Console.WriteLine($"Dispel too weak.");
                    }
                    else
                    {
                        char[] lineToChar = userName.ToCharArray();
                        lineToChar[index] = letter;
                        userName = new String(lineToChar);
                        Console.WriteLine("Success!");
                    }
                    break;
                case ("Target"):
                    if (commandSplit[1] == "Change")
                    {
                        string substring = commandSplit[2];
                        string secondSubstring = commandSplit[3];
                        userName = userName.Replace(substring, secondSubstring);
                        Console.WriteLine(userName);
                    }
                    if (commandSplit[1] == "Remove")
                    {
                        string substring = commandSplit[2];
                        userName = userName.Replace(substring, "");
                        Console.WriteLine(userName);
                    }
                    break;
            }


            input = Console.ReadLine();
        }
    }
}

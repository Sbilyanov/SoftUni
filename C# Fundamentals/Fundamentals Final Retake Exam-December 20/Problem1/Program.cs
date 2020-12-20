using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                string[] commandSplit = command.Split().ToArray();
                if ((commandSplit[0] != "GladiatorStance") && (commandSplit[0] != "DefensiveStance") && (commandSplit[0] != "For") && (commandSplit[0] != "Dispel") && (commandSplit[0] != "Target"))
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                if ((commandSplit[0] == "Target") && (commandSplit[1] != "Change") && (commandSplit[1] != "Remove"))
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                if (command == "For Azeroth")
                {
                    return;
                }
                switch (commandSplit[0])
                {
                    case ("GladiatorStance"):
                        line = line.ToUpper();
                        Console.WriteLine(line);
                        break;
                    case ("DefensiveStance"):
                        line = line.ToLower();
                        Console.WriteLine(line);
                        break;
                    case ("Dispel"):
                        int index = int.Parse(commandSplit[1]);
                        char letter = char.Parse(commandSplit[2]);
                        if ((index < 0) || (index >=line.Length))
                        {
                            Console.WriteLine($"Dispel too weak.");
                        }
                        else
                        {
                            char[] lineToChar = line.ToCharArray();
                            lineToChar[index] = letter;
                            line = new String(lineToChar);
                            Console.WriteLine("Success!");
                        }
                        break;
                    case ("Target"):
                        if (commandSplit[1] == "Change")
                        {
                            string substring = commandSplit[2];
                            string secondSubstring = commandSplit[3];
                            line = line.Replace(substring, secondSubstring);
                            Console.WriteLine(line);
                        }
                        if (commandSplit[1] == "Remove")
                        {
                            string substring = commandSplit[2];
                            line = line.Replace(substring, "");
                            Console.WriteLine(line);
                        }
                        break;
                }
            }
        }


    }
}
}

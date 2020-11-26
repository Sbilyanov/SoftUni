using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] tokens = input
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Contains":
                        if (activationKey.Contains(tokens[1]))
                        {
                            Console.WriteLine($"{activationKey} contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        string fristPart = activationKey.Substring(0, startIndex);
                        string secondPart = activationKey.Substring(startIndex, endIndex - startIndex);
                        string thridPart = activationKey.Substring(endIndex);

                        if (tokens[1].ToUpper() == "UPPER")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }
                        activationKey = fristPart + secondPart + thridPart;

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                        Console.WriteLine(activationKey);
                        break;
                    default:
                        break;

                }

                input = Console.ReadLine();
            }
                Console.WriteLine($"Your activation key is: {activationKey}");
            
        }
    }
}

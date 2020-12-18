using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasurehunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Yohoho!")
                {
                    break;
                }

                if (inputLine.Contains("Loot"))
                {
                    string[] privateTokens = inputLine.Split().Skip(1).ToArray();
                    loots = InsertAdditionalLoots(privateTokens, loots);
                }
                else
                {
                    string[] tokens = inputLine.Split();

                    string command = tokens[0];


                    if (command == "Drop")
                    {
                        int index = int.Parse(tokens[1]);
                        if (IsIndexValid(index, loots))
                        {
                            loots = DropItems(loots, index);

                        }

                    }
                    else if (command == "Steal")
                    {
                        int count = int.Parse(tokens[1]);


                        string stolenItems = StealItems(count, loots);

                        Console.WriteLine(stolenItems);
                    }
                }



            }

            if (loots.Count != 0)
            {

                int sumOfAllItemsLength = 0;

                for (int i = 0; i < loots.Count; i++)
                {
                    sumOfAllItemsLength += loots[i].Length;

                }
                double averageGain = 1.0 * sumOfAllItemsLength / loots.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else if (loots.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");

            }

        }

        static string StealItems(int count, List<string> loots)
        {
            string result = string.Empty;
            if (count > loots.Count)
            {
                var privateCaseTaken = loots.Take(loots.Count).ToList();
                for (int i = 0; i < privateCaseTaken.Count; i++)
                {
                    loots.Remove(privateCaseTaken[i]);
                }
                result = string.Join(", ", privateCaseTaken);
                return result;

            }
            var stolen = loots.Skip(Math.Abs(loots.Count - count)).Take(count).ToList();

            for (int i = 0; i < stolen.Count; i++)
            {
                loots.Remove(stolen[i]);
            }

            result = string.Join(", ", stolen);

            return result;
        }

        static List<string> DropItems(List<string> loots, int index)
        {
            string removedItem = loots[index];
            if (loots.Contains(removedItem))
            {
                loots.RemoveAt(index);
                loots.Add(removedItem);
            }



            return loots;

        }

        static bool IsIndexValid(int index, List<string> loots)
        {
            if (index >= 0 && index < loots.Count)
            {
                return true;
            }

            return false;
        }

        static List<string> InsertAdditionalLoots(string[] privateTokens, List<string> loots)
        {
            for (int i = 0; i < privateTokens.Length; i++)
            {
                if (!loots.Contains(privateTokens[i]))
                {
                    loots.Insert(0, privateTokens[i]);
                }
            }
            return loots;
        }
    }
}
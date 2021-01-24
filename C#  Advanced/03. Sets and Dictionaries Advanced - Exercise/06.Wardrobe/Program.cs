using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] {" -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input.Skip(1).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] searchedItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach ((string color, Dictionary<string, int> colorData) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach ((string cloths, int count) in colorData)
                {


                    if (color == searchedItem[0] && cloths == searchedItem[1])
                    {
                        Console.WriteLine($"* {cloths} - {count} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {cloths} - {count}");

                    }


                }
            }

        }
    }
}

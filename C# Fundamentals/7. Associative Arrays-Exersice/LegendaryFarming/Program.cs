using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMatterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMatterials = new Dictionary<string, int>();

            keyMatterials["shards"] = 0;
            keyMatterials["fragments"] = 0;
            keyMatterials["motes"] = 0;

            bool isCreated = false;


            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i+=2)
                {
                    string matterial = input[i+1].ToLower();
                    int quantity = int .Parse(input[i]);

                    if (matterial == "shards" || matterial =="fragments" || matterial =="motes") 
                    {
                        if (!keyMatterials.ContainsKey(matterial))
                        {
                            keyMatterials.Add(matterial, 0);

                        }
                        keyMatterials[matterial]+=quantity;

                        if (keyMatterials[matterial]>=250)
                        {
                            switch (matterial)
                            {
                                case "shards":
                                    Console.WriteLine($"Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine($"Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine($"Dragonwrath obtained!");
                                    break;
                            }
                            keyMatterials[matterial] -= 250;
                            
                            isCreated = true;

                            break;
                        }             
                    }
                    else
                    {
                        if (!junkMatterials.ContainsKey(matterial))
                        {
                            junkMatterials.Add(matterial, 0);
                        }
                        junkMatterials[matterial] += quantity;
                    }

                }
                if (isCreated)
                {
                    break;
                } 
                    

            }

            Dictionary<string, int> filteredKeysMatterial = keyMatterials.OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a=>a.Key,v => v.Value);

            foreach (var item in filteredKeysMatterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            
            }
            foreach (var item in junkMatterials.OrderBy(v=>v.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

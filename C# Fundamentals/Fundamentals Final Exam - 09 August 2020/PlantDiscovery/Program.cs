using System;
using System.Linq;
using System.Collections.Generic;

namespace PlantDiscovery
{
    class Plant
    {
        public string Palnt { get; set; }
        public int Rarity { get; set; }

        public List<double> Rate { get; set; }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> listPlants = new List<Plant>();

            int n = int.Parse(Console.ReadLine());
            int rateCount = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (listPlants.Any(n=>n.Palnt==plant))
                {
                    listPlants.Select(r => r.Rarity += rarity); 
                    
                }

                listPlants.Add(new Plant { Palnt = plant, Rarity = rarity, Rate = 0 }); ;
 
            }
            string token = Console.ReadLine();

            while (token != "Exhibition")
            {
                /*
                 * Rate: {plant} - {rating} – add the given rating to the plant (store all ratings)
Update: {plant} - {new_rarity} – update the rarity of the plant with the new one
Reset: {plant} – remove all the ratings of the given plant

                */
                string[] command = token.Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                var plant = command[1].Trim();

                switch (command[0])
                {
                    case "Rate":
                        int rating = int.Parse(command[2]);

                    
                        if (listPlants.Any(n => n.Palnt == plant))
                        {
                           listPlants.Select(n=>n.Palnt==plant).Where(n=>n.Rate.


                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Update":
                        int newRarity = int.Parse(command[2]);
                        if (plants.ContainsKey(plant))
                        {
                            plants[plant]["rarity"] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        if (plants.ContainsKey(plant))
                        {
                            plants[plant]["rate"] = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                token = Console.ReadLine();
            }

        }
    }
}

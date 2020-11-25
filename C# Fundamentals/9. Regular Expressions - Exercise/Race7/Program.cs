using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racersList = new Dictionary<string, int>();

            string[] racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var racer in racers)
            {
                racersList.Add(racer, 0);
            }

            string input = Console.ReadLine();

            string nameRegex = @"[(\W+\d+)]";
            string distanceRegex = @"[(\W+\D)]";
            while (input!= "end of race")
            {
                string name = Regex.Replace(input, nameRegex, "");
                string distance = Regex.Replace(input, distanceRegex, "");
                
                if (racersList.ContainsKey(name))
                {
                    int sum = 0;
                    foreach (var item in distance)
                    {
                         int currentDistance = int.Parse( item.ToString());
                        sum += currentDistance;
                    }
                    racersList[name] += sum;
                    
                }

                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var racer in racersList.OrderByDescending(r=>r.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                
                Console.WriteLine($"{count}{text} place: {racer.Key}");
                count++;
                if (count==4)
                {
                    break;
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThreeC
{
    class Hero
    {
        public string Name { get; set; }
        public List<string> Spell { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> listOfHeros = new List<Hero>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string heroName = tokens[1];

                switch (command)
                {
                    case "Enroll":
                        if (listOfHeros.Any(n => n.Name == heroName))
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        else
                        {
                            listOfHeros.Add(new Hero { Name = heroName, Spell = new List<string>() });
                        }

                        break;
                    case "Learn":
                        string spell = tokens[2];
                        if (!listOfHeros.Any(n => n.Name == heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else if (listOfHeros.Any(s => s.Spell.Contains(spell)))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spell}.");
                        }
                        else
                        {
                            int index = listOfHeros.FindIndex(x => x.Name == heroName);
                            listOfHeros[index].Spell.Add(spell);
                        }
                        break;

                    case "Unlearn":
                        spell = tokens[2];

                        if (!listOfHeros.Any(n => n.Name == heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else if (!listOfHeros.Any(s => s.Spell.Contains(spell)))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spell}.");
                        }
                        else
                        {
                            int index = listOfHeros.FindIndex(x => x.Name == heroName);
                            listOfHeros[index].Spell.Remove(spell);

                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");

            if (listOfHeros.All(s => s.Spell.Count == 0))
            {
                foreach (var hero in listOfHeros.OrderBy(n => n.Name))
                {
                    Console.WriteLine($"== {hero.Name}:");
                }

            }
            else
            {
                foreach (var hero in listOfHeros.OrderByDescending(v => v.Spell.Count).ThenBy(n => n.Name))
                {
                    Console.WriteLine($"== {hero.Name}: {string.Join(", ", hero.Spell)}");

                }
            }
  
        }
    }
}

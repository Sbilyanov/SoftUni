using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> heros = new Dictionary<string, Dictionary<string, int>>();

            int numbersofHeros = int.Parse(Console.ReadLine());
            int maxHP = 100;
            int maxMP = 200;

            for (int i = 0; i < numbersofHeros; i++)
            {
                string[] newHero = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = newHero[0];
                int HP = int.Parse(newHero[1]);
                int MP = int.Parse(newHero[2]);
                heros.Add(name, new Dictionary<string, int>()
                {
                    {"health",HP },
                    {"mana",MP}
                });

            }

            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0].ToUpper();
                string heroName = tokens[1];

                switch (command)
                {
                    case "CASTSPELL":

                        string spellName = tokens[3];
                        int MPneeded = int.Parse(tokens[2]);

                        if (heros[heroName]["mana"]>=MPneeded)
                        {
                            heros[heroName]["mana"] -= MPneeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heros[heroName]["mana"]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{ heroName} does not have enough MP to cast { spellName}!");
                        }

                        break;
                    case "TAKEDAMAGE":

                        int damage = int.Parse(tokens[2]);
                        string attacker = tokens[3];
                        heros[heroName]["health"] -= damage;
                        if (heros[heroName]["health"]>0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heros[heroName]["health"]} HP left!");
                        }
                        else
                        {
                            heros.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }

                        break;
                    case "RECHARGE":
                        int rechargeMP = int.Parse(tokens[2]);
                        int recoverdMP = (heros[heroName]["mana"] + rechargeMP);
                        if (recoverdMP>maxMP)
                        {
                            recoverdMP = rechargeMP-(recoverdMP - maxMP);
                            heros[heroName]["mana"] += recoverdMP;
                            Console.WriteLine($"{heroName} recharged for {recoverdMP} MP!");
                        }
                        else
                        {
                            heros[heroName]["mana"] += rechargeMP;
                            Console.WriteLine($"{heroName} recharged for {rechargeMP} MP!");
                        }
                            
                        break;
                    case "HEAL":
                        int rechargeHP = int.Parse(tokens[2]);
                        int recoverdHP = (heros[heroName]["health"] + rechargeHP);
                        if (recoverdHP > maxHP)
                        {
                            recoverdHP = rechargeHP - (recoverdHP - maxHP);
                            heros[heroName]["health"] += recoverdHP;
                            Console.WriteLine($"{ heroName} healed for { recoverdHP} HP!");
                        }
                        else
                        {
                            heros[heroName]["health"] += rechargeHP;
                            Console.WriteLine($"{ heroName} healed for { rechargeHP} HP!");
                        }
                        break;
                }


                input = Console.ReadLine();
            
            }

            foreach (var hero in heros.OrderByDescending(h => h.Value["health"]).ThenBy(n => n.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value["health"]}");
                Console.WriteLine($"  MP: {hero.Value["mana"]}");



            }

        }
    }
}

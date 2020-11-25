using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{

    class Demons
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Demons> allDemons = new List<Demons>();

            string pattern = @"[+-]?[0-9]+\.?[0-9]*";

            Regex namePattern = new Regex(pattern);

            string[] input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in input)
            {
                string filter = "0123456789/*-+.";

                int health = demon.Where(c => !filter.Contains(c)).Sum(c => c);

                double damage = ColuculateDamage(demon, namePattern);


                allDemons.Add(new Demons{Name = demon, Health = health, Damage = damage});
            }

            foreach (var demon in allDemons.OrderBy(d=>d.Name))
            {
                Console.WriteLine(demon);
            }


        }

        private static double ColuculateDamage(string demon, Regex namePattern)
        {
             MatchCollection matches = namePattern.Matches(demon);

            double damage = 0;
            foreach (Match item in matches)
            {
                damage += double.Parse(item.Value);  
            }

            foreach (var ch in demon)
            {
                if (ch=='/')
                {
                    damage = damage / 2;
                }
                if (ch=='*')
                {
                    damage = damage * 2;
                }
            }

            return damage;
        }

    }
}

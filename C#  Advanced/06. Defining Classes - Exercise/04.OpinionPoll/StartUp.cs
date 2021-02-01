using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(current[0], int.Parse(current[1]));

                people.Add(person);

            }

           List<Person> sortedPeople= people.OrderBy(n => n.Name).Where(a => a.Age > 30).ToList();

            foreach (var item in sortedPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            };
            
        }
    }
}

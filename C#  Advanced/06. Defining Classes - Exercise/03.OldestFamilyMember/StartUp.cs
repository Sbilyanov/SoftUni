using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(current[0], int.Parse(current[1]));

                family.AddMember(person);

            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }
}

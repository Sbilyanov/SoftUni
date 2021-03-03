using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (input != "END")
            {
                string[] elements = input.Split();
                Person currentPerson = new Person(elements[0], int.Parse(elements[1]), elements[2]);
                persons.Add(currentPerson);
                input = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine());
            Person personToCompare = persons[n-1];
            int equalCount = 0;
            int notEqualCount = 0;
            foreach (Person person in persons)
            {
                int index = person.CompareTo(personToCompare);
                if (index != 0)
                {
                    notEqualCount++;
                }
                else
                {
                    equalCount++;
                }

            }
            if (equalCount > 1)
            {
                Console.WriteLine($"{equalCount} {notEqualCount} {persons.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}

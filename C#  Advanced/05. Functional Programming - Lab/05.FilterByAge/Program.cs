using System;

namespace _05.FilterByAge
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string filter = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> condition = GetAgecondition(filter,ageFilter);
            Func<Person, string> formatter = GetFormatter(format);

            PrintNames(people,condition,formatter);
        }

        static Func<Person,bool> GetAgecondition(string filter,int agefilter)
        {
            switch (filter)
            {
                case "younger":return p => p.Age < agefilter;
                case "older":return p => p.Age >= agefilter;
                default:return null;
                   
            }
        }

        static Func<Person,string>GetFormatter(string format)
        {
            switch (format)
            {
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                case "name":
                    return p => $"{p.Name}";
                case "age":
                    return p => $"{p.Age}";

                default:
                    return null;
                   
            }
        }

        private static void PrintNames(Person[] people, Func<Person, bool> condition,Func<Person,string>formatter)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(formatter(person));
                }
            }
        }
    }
}

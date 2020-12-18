using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] element = input.Split().ToArray();
                string name = element[0];
                int idNumber = int.Parse(element[1]);
                int age = int.Parse(element[2]);
                Students currentStudent = new Students(name, idNumber, age);
                students.Add(currentStudent);

                input = Console.ReadLine();
            }
            students=students.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
           
        }
    }
    class Students
    {
        public Students(string name, int idNumber,int age)
        {
            Name = name;
            IdNumber = idNumber;
            Age = age;

        }

        public string Name { get; set; }
        public int IdNumber { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"{Name} with ID: {IdNumber} is {Age} years old.";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input!="end")
            {
                string[] command = input.Split(" : ");

                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(c=>c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var item in course.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {item}");

                }

             
            
            }

        }
    }
}

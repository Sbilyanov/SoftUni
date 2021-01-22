using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < studentsNumber; i++)
            {
                string[] currentStudent = Console.ReadLine().Split();
                string name = currentStudent[0];
                decimal grade = decimal.Parse(currentStudent[1]);
                if (!studentsGrades.ContainsKey(currentStudent[0]))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }
                studentsGrades[name].Add(grade);

            }
            foreach (var student in studentsGrades)
            {
             Console.WriteLine(
                 $"{student.Key} -> {string.Join(' ', student.Value.Select(v=>v.ToString("f2")))} (avg: {student.Value.Average():f2})");


                /*
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");*/
            }
        }
    }
}

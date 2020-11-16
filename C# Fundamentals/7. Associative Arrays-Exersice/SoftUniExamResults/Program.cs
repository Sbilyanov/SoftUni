using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentResults = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] elements = input.Split("-");
                string studentName = elements[0];
                string language = elements[1];

                if (elements.Length > 2)
                {
                    int result = int.Parse(elements[2]);


                    if (!studentResults.ContainsKey(studentName))
                    {

                        studentResults.Add(studentName, result);
                    }

                    if (studentResults[studentName] < result)
                    {
                        studentResults[studentName] = result;
                    }



                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);

                    }
                    submissions[language]++;
                }
                else
                {
                    studentResults.Remove(studentName);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var student in studentResults.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissions.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] array = input.Split("->");
                string companyName = array[0];
                string employeeID = array[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());

                }
               
                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }


                input = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"--{employee}");
                }
            }

        }
    }
}

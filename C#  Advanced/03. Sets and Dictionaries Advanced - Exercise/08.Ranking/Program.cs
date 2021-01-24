using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestList = new Dictionary<string, string>();

            string contestInput = Console.ReadLine();

            while (contestInput != "end of contests")
            {
                string[] contestData = contestInput.Split(':');

                contestList.Add(contestData[0], contestData[1]);

                contestInput = Console.ReadLine();
            }

            SortedDictionary<string, Dictionary<string, int>> userList = new SortedDictionary<string, Dictionary<string, int>>();

            string submisionInput = Console.ReadLine();

            while (submisionInput != "end of submissions")
            {
                string[] submisionDate = submisionInput.Split("=>");
                string contest = submisionDate[0];
                string password = submisionDate[1];
                string userName = submisionDate[2];
                int points = int.Parse(submisionDate[3]);

                if (!contestList.ContainsKey(contest) || contestList[contest] != password)
                {
                    submisionInput = Console.ReadLine();
                    continue;
                }

                if (!userList.ContainsKey(userName))
                {
                    userList.Add(userName, new Dictionary<string, int>());
                }
                if (!userList[userName].ContainsKey(contest))
                {
                    userList[userName].Add(contest, points);
                }
                else
                {
                    int oldPoints = userList[userName][contest];

                    if (points>oldPoints)
                    {
                        userList[userName][contest] = points;
                    }
                }

                submisionInput = Console.ReadLine();
            }
       
          KeyValuePair<string,Dictionary<string,int>> bestCandidate = userList.OrderByDescending(kvp => kvp.Value.Values.Sum()).First();
            int totalPoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var student in userList)
            {
                Console.WriteLine(student.Key);

                foreach (var item in student.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine( $"#  {item.Key} -> {item.Value}" );
                }
            }
        }
    }
}

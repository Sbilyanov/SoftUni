using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] elements = Console.ReadLine().Split("-").ToArray();
                string teamName = elements[1];
                string creator = elements[0];
                Team currentTeam = new Team(teamName, creator);

                bool isTeamIsCreated = teams.Select(x => x.TeamName).Contains(teamName);
                bool isUserExist = teams.Select(x => x.Creator).Contains(creator);
                if (!isTeamIsCreated)
                {
                    if (!isUserExist)
                    {
                        
                        teams.Add(currentTeam);
                       
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }

                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine,teams));

            string command = Console.ReadLine();
            while (command!= "end of assignment")
            {
                string[] elemnts = command.Split(new char[] { '-', '>'  }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string newUser = elemnts[0];
                string teamName = elemnts[1];

                bool isTeamIsCreated = teams.Select(x => x.TeamName).Contains(teamName);
                bool isUserExist = teams.Select(x => x.Creator).Contains(newUser);
                bool isAlreadyMember = teams.Select(x => x.Members).Any(x=>x.Contains(newUser));
                if (!isTeamIsCreated)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");

                }
                if (isAlreadyMember|| isUserExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }
                command = Console.ReadLine();
            }
            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0).ToArray();
            Team[] fullTeams = teams.OrderByDescending(n => n.Members.Count)
                .ThenBy(n => n.TeamName)
                .Where(n => n.Members.Count > 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            StringBuilder td = new StringBuilder();


            foreach (Team team in fullTeams)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"-{team.Creator}");
                foreach (var member  in team.Members.OrderBy(n=>n))
                {
                    sb.AppendLine($"--{member}");

                }
            
            }
            Console.WriteLine(sb.ToString());
      
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                td.AppendLine(team.TeamName);
            }

            Console.WriteLine(td.ToString());


        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"Team {TeamName} has been created by {Creator}!";
        }
    }
   

}

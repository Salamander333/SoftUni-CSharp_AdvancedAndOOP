using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projectsV2
{
    class Team
    {
        public string TeamName { get; set; }
        public string TeamCreatorName { get; set; }
        public List<string> Members { get; set; }

        public Team(string teamName, string teamCreatorName)
        {
            bool teamNameUnvailable = Program.teams.Any(x => x.TeamName == teamName);
            if (teamNameUnvailable)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return;
            }

            bool creatorCreatedATeam = Program.teams.Any(x => x.TeamCreatorName == teamCreatorName);
            if (creatorCreatedATeam)
            {
                Console.WriteLine($"{teamCreatorName} cannot create another team!");
                return;
            }

            CreateTeam(teamName, teamCreatorName);
        }
        void CreateTeam(string teamName, string teamCreatorName)
        {
            this.TeamName = teamName;
            this.TeamCreatorName = teamCreatorName;
            this.Members = new List<string>();
            Console.WriteLine($"Team {teamName} has been created by {teamCreatorName}!");
            Program.teams.Add(this);
        }
    }

    class Program
    {
        public static List<Team> teams = new List<Team>();

        static void Main(string[] args)
        {
            int teamCreationCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCreationCount; i++)
            {
                var team = Console.ReadLine().Split("-");
                new Team(team[1], team[0]);
            }

            var input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] data = input.Split("->");
                string member = data[0];
                string teamToJoin = data[1];

                bool ifTeamExists = Program.teams.Any(x => x.TeamName == teamToJoin);

                if (ifTeamExists)
                {
                    bool ifMemberIsInTeam = Program.teams.Any(x => x.Members.Contains(member));
                    if (ifMemberIsInTeam || Program.teams.Any(x => x.TeamCreatorName == member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        AddMemberToTeam(member, teamToJoin);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                input = Console.ReadLine();
            }

            var teamsToDisband = Program.teams.FindAll(x => x.Members.Count == 0).ToList();
            var validTeams = Program.teams.FindAll(x => x.Members.Count > 0).ToList();
            teamsToDisband = teamsToDisband.OrderBy(x => x.TeamName).ToList();
            validTeams = validTeams.OrderByDescending(x => x.Members.Count).ThenBy(s => s.TeamName).ToList();

            foreach (var team in validTeams)
            {
                team.Members.Sort();
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.TeamCreatorName}");
                for (int i = 0; i < team.Members.Count; i++)
                {
                    Console.WriteLine($"-- {team.Members[i]}");
                }
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }

        public static void AddMemberToTeam(string member, string teamToJoin)
        {
            var team = Program.teams.Find(x => x.TeamName == teamToJoin);
            team.Members.Add(member);
        }
    }
}

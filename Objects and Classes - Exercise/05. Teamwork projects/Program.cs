using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    static class Teams
    {
        public static List<Team> teams = new List<Team>();
    }

    class Team
    {
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public List<string> Members { get; set; }

        public Team(string teamName, string teamCreator)
        {
            var notAvailableTeamName = false;
            var notAvailableCreator = false;

            if (Teams.teams != null)
            {
                notAvailableTeamName = Teams.teams.Any(x => x.TeamName == teamName);
                notAvailableCreator = Teams.teams.Any(x => x.TeamCreator == teamCreator);
            }

            if (notAvailableTeamName)
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (notAvailableCreator)
            {
                Console.WriteLine($"{teamCreator} cannot create another team!");
            }
            else
            {
                this.TeamName = teamName;
                this.TeamCreator = teamCreator;
                this.Members = new List<string>();
                Teams.teams.Add(this);
                Teams.teams.Find(x => x.TeamName == teamName).Members.Add(teamCreator);
                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeamsToRegister = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeamsToRegister; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");

                string teamCreator = teamInfo[0];
                string teamName = teamInfo[1];

                new Team(teamName, teamCreator);
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] data = input.Split("->");
                string memberName = data[0];
                string teamForMemberToJoin = data[1];

                var ifTeamExists = Teams.teams.Any(x => x.TeamName == teamForMemberToJoin);
                if (ifTeamExists)
                {
                    var ifMemberIsInATeam = Teams.teams.Any(x => x.Members.Contains(memberName));
                    if (ifMemberIsInATeam)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamForMemberToJoin}!");
                    }
                    else
                    {
                        Teams.teams.Find(x => x.TeamName == teamForMemberToJoin).Members.Add(memberName);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamForMemberToJoin} does not exist!");
                }

                input = Console.ReadLine();
            }

            var validTeams = Teams.teams.FindAll(x => x.Members.Count > 1);
            validTeams = validTeams.OrderBy(x => x.TeamName).ToList();

            var teamsToDisband = Teams.teams.FindAll(x => x.Members.Count == 1);
            teamsToDisband = teamsToDisband.OrderBy(x => x.TeamName).ToList();

            foreach (var team in validTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Members[0]}");
                for (int i = 1; i < team.Members.Count; i++)
                {
                    Console.WriteLine($"-- {team.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}

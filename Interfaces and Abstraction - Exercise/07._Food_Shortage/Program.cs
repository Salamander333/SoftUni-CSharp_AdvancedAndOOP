using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<IBuyer>();

            int peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                var person = Console.ReadLine().Split();
                switch (person.Length)
                {
                    case 3:
                        var rebelName = person[0];
                        var rebelAge = int.Parse(person[1]);
                        var rebelGroup = person[2];
                        var rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                        people.Add(rebel);
                        break;
                    case 4:
                        var citizenName = person[0];
                        var citizenAge = int.Parse(person[1]);
                        var citizenId = person[2];
                        var citizenBirthdate = person[3];
                        var citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate);
                        people.Add(citizen);
                        break;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine(people.Select(x => x.Food).Sum());
                    return;
                }

                var person = people.Find(x => x.Name == input);
                if (person != null)
                {
                    person.BuyFood();
                }
            }
        }
    }
}

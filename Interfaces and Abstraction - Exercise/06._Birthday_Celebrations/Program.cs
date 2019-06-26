using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Birthday_Celebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var entitiesCelebratingBirthdays = new List<IBorn>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    var yearToPrint = Console.ReadLine();
                    entitiesCelebratingBirthdays
                        .Select(x => x.Birthdate)
                        .Where(x => x.EndsWith(yearToPrint))
                        .ToList()
                        .ForEach(Console.WriteLine);

                    return;
                }

                var entity = input.Split();

                switch (entity[0])
                {
                    case "Pet":
                        var petName = entity[1];
                        var petBirthday = entity[2];
                        var pet = new Pet(petName, petBirthday);
                        entitiesCelebratingBirthdays.Add(pet);
                        break;
                    case "Citizen":
                        var citizenName = entity[1];
                        var citizenAge = int.Parse(entity[2]);
                        var citizenId = entity[3];
                        var citizenBirthday = entity[4];
                        var citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthday);
                        entitiesCelebratingBirthdays.Add(citizen);
                        break;
                }
            }
        }
    }
}

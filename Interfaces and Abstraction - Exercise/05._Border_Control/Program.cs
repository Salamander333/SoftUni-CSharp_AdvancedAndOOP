using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<IIdentifiable>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var entity = input.Split();

                switch (entity.Length)
                {
                    case 2:
                        var robotModel = entity[0];
                        var robotId = entity[1];
                        var robot = new Robot(robotModel, robotId);
                        entities.Add(robot);
                        break;
                    case 3:
                        var citizenName = entity[0];
                        var citizenAge = int.Parse(entity[1]);
                        var citizenId = entity[2];
                        var citizen = new Citizen(citizenName, citizenAge, citizenId);
                        entities.Add(citizen);
                        break;
                }
            }

            var fakeIdCheck = Console.ReadLine();

            entities.Select(x => x.Id).Where(x => x.EndsWith(fakeIdCheck)).ToList().ForEach(Console.WriteLine);
        }
    }
}

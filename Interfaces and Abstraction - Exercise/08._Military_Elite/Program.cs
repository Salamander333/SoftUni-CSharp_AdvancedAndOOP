using System;
using System.Collections.Generic;
using System.Linq;
using _08._Military_Elite.Interfaces;
using _08._Military_Elite.SoldierTypes;

namespace _08._Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
            var army = new List<ISoldier>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    foreach (var soldier in army)
                    {
                        Console.WriteLine(soldier);
                    }
                    return;
                }

                var person = input.Split();
                var personId = person[1];
                var firstName = person[2];
                var lastName = person[3];
                var salary = decimal.Parse(person[4]);

                switch (person[0])
                {
                    case "Private":
                        var _private = new Private(personId, firstName, lastName, salary);
                        army.Add(_private);
                        break;

                    case "LieutenantGeneral":
                        var privates = new List<ISoldier>();
                        foreach (var id in person.Skip(5))
                        {
                            privates.Add(army.FirstOrDefault(x => x.ID == id));
                        }
                        var leutenantgeneral = new LeutenantGeneral(personId, firstName, lastName, salary, privates);
                        army.Add(leutenantgeneral);
                        break;

                    case "Engineer":
                        var corps = person[5];
                        var repairs = new List<Repair>();
                        if (person.Length > 6)
                        {
                            for (int i = 6; i < person.Length; i += 2)
                            {
                                var partName = person[i];
                                var workedHours = int.Parse(person[i + 1]);
                                var part = new Repair(partName, workedHours);
                                repairs.Add(part);
                            }
                        }
                        try
                        {
                            var engineer = new Engineer(personId, firstName, lastName, salary, corps, repairs);
                            army.Add(engineer);
                        }
                        catch (Exception) { }
                        break;

                    case "Commando":
                        corps = person[5];
                        var missions = new List<Mission>();
                        if (person.Length > 6)
                        {
                            for (int i = 6; i < person.Length; i += 2)
                            {
                                var codeName = person[i];
                                var state = person[i + 1];
                                try
                                {
                                    var mission = new Mission(codeName, state);
                                    missions.Add(mission);
                                }
                                catch (Exception) {}
                            }
                        }
                        try
                        {
                            var commando = new Commando(personId, firstName, lastName, salary, corps, missions);
                            army.Add(commando);
                        }
                        catch (Exception) { }
                        break;

                    case "Spy":
                        var codeNumber = int.Parse(person[4]);
                        var spy = new Spy(personId, firstName, lastName, codeNumber);
                        army.Add(spy);
                        break;
                }
            }
        }
    }
}

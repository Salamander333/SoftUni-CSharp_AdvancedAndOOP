using System;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];
                
                if (command == "Party!")
                {
                    break;
                }

                var criteriaRule = input[1];
                var criteria = input[2];

                switch (command)
                {
                    case "Remove":
                        switch (criteriaRule)
                        {
                            case "StartsWith":
                                names.RemoveAll(s => s.StartsWith(criteria));
                                break;
                            case "EndsWith":
                                names.RemoveAll(s => s.EndsWith(criteria));
                                break;
                            case "Length":
                                names.RemoveAll(s => s.Length == int.Parse(criteria));
                                break;
                        }
                        break;

                    case "Double":
                        switch (criteriaRule)
                        {
                            case "StartsWith":
                                var peopleToAdd = names.FindAll(x => x.StartsWith(criteria));
                                foreach (var person in peopleToAdd)
                                {
                                    int index = names.IndexOf(person);
                                    names.Insert(index + 1, person);
                                }
                                //names.AddRange(names.FindAll(x => x.StartsWith(criteria)));
                                break;
                            case "EndsWith":
                                peopleToAdd = names.FindAll(x => x.EndsWith(criteria));
                                foreach (var person in peopleToAdd)
                                {
                                    int index = names.IndexOf(person);
                                    names.Insert(index + 1, person);
                                }
                                //names.AddRange(names.FindAll(x => x.EndsWith(criteria)));
                                break;
                            case "Length":
                                peopleToAdd = names.FindAll(x => x.Length == int.Parse(criteria));
                                foreach (var person in peopleToAdd)
                                {
                                    int index = names.IndexOf(person);
                                    names.Insert(index + 1, person);
                                }
                                //names.AddRange(names.FindAll(x => x.Length == int.Parse(criteria)));
                                break;
                        }
                        break;
                }
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}

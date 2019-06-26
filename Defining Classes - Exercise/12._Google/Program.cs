using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Google
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var name = input[0];
                var exists = false;
                if (people.Any(x => x.Name == name))
                {
                    exists = true;
                }
                else
                {
                    var p = new Person(name);
                    p.Pokemons = new List<Pokemon>();
                    p.Parents = new List<Parent>();
                    p.Children = new List<Child>();
                    people.Add(p);
                }

                var obj = input[1];

                switch (obj)
                {
                    case "company":
                        var companyName = input[2];
                        var companyDepartmen = input[3];
                        var companySalary = decimal.Parse(input[4]);

                        var pp = people.Find(x => x.Name == name);
                        pp.Company = new Company(companyName, companyDepartmen, companySalary);
                        break;

                    case "pokemon":
                        if (exists)
                        {
                            var pokemonName = input[2];
                            var pokemonType = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        }
                        else
                        {
                            var pokemonName = input[2];
                            var pokemonType = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        }
                        break;

                    case "parents":
                        if (exists)
                        {
                            var parentName = input[2];
                            var parentBirthday = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Parents.Add(new Parent(parentName, parentBirthday));
                        }
                        else
                        {
                            var parentName = input[2];
                            var parentBirthday = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Parents.Add(new Parent(parentName, parentBirthday));
                        }
                        break;

                    case "children":
                        if (exists)
                        {
                            var childName = input[2];
                            var childBirthday = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Children.Add(new Child(childName, childBirthday));
                        }
                        else
                        {
                            var childName = input[2];
                            var childBirthday = input[3];

                            var person = people.Find(x => x.Name == name);
                            person.Children.Add(new Child(childName, childBirthday));
                        }
                        break;

                    case "car":
                        var carModel = input[2];
                        var carSpeed = int.Parse(input[3]);

                        var ppp = people.Find(x => x.Name == name);
                        ppp.Car = new Car(carModel, carSpeed);
                        break;
                }
            }

            var personToPrint = Console.ReadLine();
            var result = people.Find(x => x.Name == personToPrint);

            Console.WriteLine(result);

        }
    }
}

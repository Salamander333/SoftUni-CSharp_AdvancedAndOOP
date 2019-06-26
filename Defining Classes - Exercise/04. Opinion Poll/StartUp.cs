using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();

            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var personArgs = Console.ReadLine().Split();
                var personName = personArgs[0];
                var personAge = int.Parse(personArgs[1]);

                var person = new Person(personName, personAge);
                people.Add(person);
            }

            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}

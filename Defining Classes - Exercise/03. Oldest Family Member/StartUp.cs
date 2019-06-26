using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < inputCount; i++)
            {
                var personArgs = Console.ReadLine().Split();
                var personName = personArgs[0];
                var personAge = int.Parse(personArgs[1]);

                var person = new Person(personName, personAge);
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember);
        }
    }
}

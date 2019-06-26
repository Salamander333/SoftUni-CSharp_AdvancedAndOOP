using System;
using System.Collections.Generic;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Family.AddPerson(name, age);
            }

            var oldestFamilyMember = Family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public static List<Person> People = new List<Person>();

        public static void AddPerson(string name, int age)
        {
            var person = new Person
            {
                Name = name,
                Age = age
            };
            People.Add(person);
        }

        public static Person GetOldestMember()
        {
            Person oldestPerson = null;

            foreach (Person person in People)
            {
                if (oldestPerson == null)
                {
                    oldestPerson = person;
                }
                else if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }
    }
}

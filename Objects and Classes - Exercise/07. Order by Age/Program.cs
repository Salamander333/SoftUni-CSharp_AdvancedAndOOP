using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Person(string name, int id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
            Program.people.Add(this);
        }
    }

    class Program
    {
        public static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split();
                string name = data[0];
                int id = int.Parse(data[1]);
                int age = int.Parse(data[2]);

                new Person(name, id, age);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}

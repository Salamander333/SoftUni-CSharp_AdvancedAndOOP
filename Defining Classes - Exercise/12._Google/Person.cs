using System;
using System.Collections.Generic;
using System.Text;

namespace _12._Google
{
    class Person
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Child> Children { get; set; }

        public Car Car { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Name}");
            sb.AppendLine($"Company:");
            if (this.Company != null)
            {
                sb.AppendLine($"{Company.Name} {Company.Department} {Company.Salary}");

            }
            sb.AppendLine($"Car:");
            if (this.Car != null)
            {
                sb.AppendLine($"{Car.Model} {Car.Speed}");
            }
            sb.AppendLine($"Pokemon:");
            foreach (var pokemon in Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }
            sb.AppendLine($"Parents:");
            foreach (var parent in Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }
            sb.AppendLine($"Children:");
            foreach (var child in Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }

            return sb.ToString();
        }
    }
}

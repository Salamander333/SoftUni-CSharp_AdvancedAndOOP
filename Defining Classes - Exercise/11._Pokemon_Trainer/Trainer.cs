using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Pokemon_Trainer
{
    class Trainer
    {
        public string Name { get; private set; }

        public int Badges { get;  set; }

        public List<Pokemon> Pokemons { get; private set; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}

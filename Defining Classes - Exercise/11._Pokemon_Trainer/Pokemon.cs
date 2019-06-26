using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Pokemon_Trainer
{
    class Pokemon
    {
        public string Name { get; private set; }

        public string Element { get; private set; }

        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}

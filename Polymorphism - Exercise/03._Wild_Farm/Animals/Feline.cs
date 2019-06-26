using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Wild_Farm.Animals
{
    abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }
    }
}

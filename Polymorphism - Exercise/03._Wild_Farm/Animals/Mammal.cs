using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Wild_Farm.Animals
{
    abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
    }
}

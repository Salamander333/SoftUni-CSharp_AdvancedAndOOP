using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Car_Salesman
{
    public class Engine
    {
        public string Model { get; private set; }

        public int Power { get; private set; }

        public int Displacement { get; private set; }

        public string Efficiency { get; private set; }

        public Engine(string model, int power,int displacement, string eficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = eficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a") { }
        public Engine(string model, int power, string efficiency) : this(model, power, -1, efficiency) { }
        public Engine(string model, int power) : this(model, power, -1, "n/a") { }
    }
}

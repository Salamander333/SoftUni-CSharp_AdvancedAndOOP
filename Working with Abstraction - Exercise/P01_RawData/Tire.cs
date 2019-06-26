using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Tire
    {
        private double tirePressure;
        private int tireAge;

        public Tire(double tirePressure, int tireAge)
        {
            this.tirePressure = tirePressure;
            this.tireAge = tireAge;
        }

        public double TirePressure { get => this.tirePressure; }

        public int TireAge { get => this.tireAge; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    public class Tire
    {
        private int tireAge;
        private double tirePressure;

        public int TireAge
        {
            get { return tireAge; }
        }

        public double TirePressure
        {
            get { return tirePressure; }
        }

        public Tire(int tireAge, double tirePressure)
        {
            this.tireAge = tireAge;
            this.tirePressure = tirePressure;
        }
    }
}

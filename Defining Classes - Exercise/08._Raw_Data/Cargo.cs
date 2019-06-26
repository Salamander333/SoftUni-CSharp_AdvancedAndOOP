using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public int CargoWeight
        {
            get { return cargoWeight; }
        }

        public string CargoType
        {
            get { return cargoType; }
        }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }
    }
}

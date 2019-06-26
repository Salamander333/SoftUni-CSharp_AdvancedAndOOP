using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }

        public int CargoWeight { get => this.cargoWeight; }

        public string CargoType { get => this.cargoType; }
    }
}

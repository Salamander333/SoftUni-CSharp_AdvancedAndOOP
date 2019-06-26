using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires = new List<Tire>();
            var tire1 = new Tire(tire1Pressure, tire1Age);
            var tire2 = new Tire(tire2Pressure, tire2Age);
            var tire3 = new Tire(tire3Pressure, tire3Age);
            var tire4 = new Tire(tire4Pressure, tire4Age);
            tires.Add(tire1);
            tires.Add(tire2);
            tires.Add(tire3);
            tires.Add(tire4);
        }

        public string Model { get => this.model; }

        public Engine Engine { get => this.engine; }

        public Cargo Cargo { get => this.cargo; }

        public List<Tire> Tires { get => this.tires; }
    }
}

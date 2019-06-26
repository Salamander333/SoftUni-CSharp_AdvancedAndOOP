using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public string Model
        {
            get { return model; }
        }

        public Engine Engine
        {
            get { return engine; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
        }

        public List<Tire> Tires
        {
            get { return tires; }
        }

        public Car(
            string model,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            double tire1_pressure,
            int tire1_age,
            double tire2_pressure,
            int tire2_age,
            double tire3_pressure,
            int tire3_age,
            double tire4_pressure,
            int tire4_age
            )
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            var tire_1 = new Tire(tire1_age, tire1_pressure);
            var tire_2 = new Tire(tire2_age, tire2_pressure);
            var tire_3 = new Tire(tire3_age, tire3_pressure);
            var tire_4 = new Tire(tire4_age, tire4_pressure);
            this.tires = new List<Tire>();
            tires.Add(tire_1);
            tires.Add(tire_2);
            tires.Add(tire_3);
            tires.Add(tire_4);
        }
    }
}

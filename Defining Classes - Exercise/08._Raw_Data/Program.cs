using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Raw_Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < inputLines; i++)
            {
                var car = Console.ReadLine().Split();
                var model = car[0];
                var engineSpeed = int.Parse(car[1]);
                var enginePower = int.Parse(car[2]);
                var cargoWeight = int.Parse(car[3]);
                var cargoType = car[4];
                var tire1_pressure = double.Parse(car[5]);
                var tire1_age = int.Parse(car[6]);
                var tire2_pressure = double.Parse(car[7]);
                var tire2_age = int.Parse(car[8]);
                var tire3_pressure = double.Parse(car[9]);
                var tire3_age = int.Parse(car[10]);
                var tire4_pressure = double.Parse(car[11]);
                var tire4_age = int.Parse(car[12]);

                var c = new Car(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType,
                    tire1_pressure,
                    tire1_age,
                    tire2_pressure,
                    tire2_age,
                    tire3_pressure,
                    tire3_age,
                    tire4_pressure,
                    tire4_age);

                cars.Add(c);
            }

            var command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    cars = cars.Where(x => x.Cargo.CargoType == "fragile").Where(s => s.Tires.Exists(tire => tire.TirePressure < 1)).ToList();
                    break;
                case "flamable":
                    cars = cars.Where(x => x.Cargo.CargoType == "flamable").Where(s => s.Engine.EnginePower > 250).ToList();
                    break;
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

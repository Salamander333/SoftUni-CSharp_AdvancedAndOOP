using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                var car = new Car
                {
                    Model = model,
                    EnignePower = enginePower,
                    EngineSpeed = engineSpeed,
                    CargoWeight = cargoWeight,
                    CargoType = cargoType
                };

                cars.Add(car);
            }

            string typeToTrack = Console.ReadLine();
            List<Car> listOfVeichlesToDisplay = new List<Car>();

            switch (typeToTrack)
            {
                case "fragile":
                    foreach (var car in cars)
                    {
                        if (car.CargoType == "fragile" && car.CargoWeight < 1000)
                        {
                            listOfVeichlesToDisplay.Add(car);
                        }
                    }
                    break;

                case "flamable":
                    foreach (var car in cars)
                    {
                        if (car.CargoType == "flamable" && car.EnignePower > 250)
                        {
                            listOfVeichlesToDisplay.Add(car);
                        }
                    }
                    break;
            }

            foreach (var car in listOfVeichlesToDisplay)
            {
                Console.WriteLine($"{car.Model}");
            }

        }
    }

    class Car
    {
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnignePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}

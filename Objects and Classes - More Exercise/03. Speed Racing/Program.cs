using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string carModel = input[0];
                double carFuelAmount = double.Parse(input[1]);
                double carFuelConsumptuion = double.Parse(input[2]);

                Cars.Add(new Car { Model = carModel, FuelAmount = carFuelAmount, FuelConsimptionForOneKm = carFuelConsumptuion, DistanceTraveled = 0 });
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();

                Car car = Cars.Find(x => x.Model == input[1]);
                int ammountOfKm = int.Parse(input[2]);

                if (!Car.CanMoveTheDistance(car, ammountOfKm))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    car.DistanceTraveled += ammountOfKm;
                    double calc = car.FuelConsimptionForOneKm * ammountOfKm;
                    car.FuelAmount -= calc;
                }

                command = Console.ReadLine();
            }

            foreach (var car in Cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsimptionForOneKm { get; set; }
        public int DistanceTraveled { get; set; }

        public static bool CanMoveTheDistance(Car car, int distance)
        {
            if (distance * car.FuelConsimptionForOneKm > car.FuelAmount)
            {
                return false;
            }
            return true;
        }
    }
}

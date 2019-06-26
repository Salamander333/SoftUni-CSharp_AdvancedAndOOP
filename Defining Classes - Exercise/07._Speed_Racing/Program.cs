using System;
using System.Collections.Generic;

namespace _07._Speed_Racing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int carsToCreate = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < carsToCreate; i++)
            {
                var car = Console.ReadLine().Split();

                var carModel = car[0];
                var carFuelAmount = double.Parse(car[1]);
                var carFuelConsumption = double.Parse(car[2]);

                var c = new Car(carModel, carFuelAmount, carFuelConsumption);
                cars.Add(c);
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var model = input[1];
                var distanceToTravel = double.Parse(input[2]);

                var carToTravel = cars.Find(x => x.Model == model);

                if (carToTravel.CanTravel(distanceToTravel))
                {
                    carToTravel.Travel(distanceToTravel);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}

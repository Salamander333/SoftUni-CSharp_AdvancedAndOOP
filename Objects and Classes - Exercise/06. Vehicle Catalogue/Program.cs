using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    static class Catalogue
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>();
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            if (type == "car")
            {
                type = "Car";
            }
            if (type == "truck")
            {
                type = "Truck";
            }
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
            Catalogue.Vehicles.Add(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split();
                string type = data[0];
                string model = data[1];
                string color = data[2];
                int horsepower = int.Parse(data[3]);

                new Vehicle(type, model, color, horsepower);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                var modelToFind = input;

                var vehicle = Catalogue.Vehicles.Find(x => x.Model == modelToFind);

                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");

                input = Console.ReadLine();
            }

            int carCount = 0;
            var averageCarHP = 0.00;
            int truckCount = 0;
            var averageTruckHP = 0.00;

            foreach (var item in Catalogue.Vehicles)
            {
                if (item.Type == "Car")
                {
                    carCount++;
                    averageCarHP += item.Horsepower;
                }
                if (item.Type == "Truck")
                {
                    truckCount++;
                    averageTruckHP += item.Horsepower;
                }
            }

            averageCarHP = averageCarHP / carCount;
            averageTruckHP = averageTruckHP / truckCount;

            if (carCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");

            }

            if (truckCount == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
            }
        }
    }
}

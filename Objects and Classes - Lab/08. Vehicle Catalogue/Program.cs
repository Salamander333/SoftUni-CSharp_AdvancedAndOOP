using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var data = input.Split("/");

                var type = data[0];
                var brand = data[1];
                var model = data[2];
                var horsePower_or_weight = int.Parse(data[3]);

                switch (type)
                {
                    case "Car":
                        var car = new Car
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = horsePower_or_weight
                        };
                        catalog.Cars.Add(car);
                        break;
                    case "Truck":
                        var truck = new Truck
                        {
                            Brand = brand,
                            Model = model,
                            Weight = horsePower_or_weight
                        };
                        catalog.Trucks.Add(truck);
                        break;
                }

                input = Console.ReadLine();
            }

            catalog.Cars = catalog.Cars.OrderBy(s => s.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(s => s.Brand).ToList();

            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}

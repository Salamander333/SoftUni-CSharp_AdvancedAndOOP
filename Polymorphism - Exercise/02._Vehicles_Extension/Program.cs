using System;

namespace _02._Vehicles_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(0, 0, 0);
            var truck = new Truck(0, 0, 0);
            var bus = new Bus(0, 0, 0);

            for (int i = 0; i < 3; i++)
            {
                var veichleInfo = Console.ReadLine().Split();
                var veichleFuelQuantity = double.Parse(veichleInfo[1]);
                var veichleFuelConsumption = double.Parse(veichleInfo[2]);
                var veichleTankCapacity= double.Parse(veichleInfo[3]);

                switch (veichleInfo[0])
                {
                    case "Car":
                        car = new Car(veichleFuelQuantity, veichleFuelConsumption, veichleTankCapacity);
                        break;
                    case "Truck":
                        truck = new Truck(veichleFuelQuantity, veichleFuelConsumption, veichleTankCapacity);
                        break;
                    case "Bus":
                        bus = new Bus(veichleFuelQuantity, veichleFuelConsumption, veichleTankCapacity);
                        break;
                }
            }

            var commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "DriveEmpty":
                        var distance = double.Parse(command[2]);
                        Console.WriteLine(bus.DriveEmpty(distance));
                        break;
                    case "Drive":
                        distance = double.Parse(command[2]);
                        switch (command[1])
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(distance));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(distance));
                                break;
                            case "Bus":
                                Console.WriteLine(bus.Drive(distance));
                                break;
                        }
                        break;
                    case "Refuel":
                        var amount = double.Parse(command[2]);
                        try
                        {
                            switch (command[1])
                            {
                                case "Car":
                                    car.Refuel(amount);
                                    break;
                                case "Truck":
                                    truck.Refuel(amount);
                                    break;
                                case "Bus":
                                    bus.Refuel(amount);
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}

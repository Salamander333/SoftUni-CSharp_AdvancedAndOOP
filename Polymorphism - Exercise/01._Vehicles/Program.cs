using System;

namespace _01._Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carArgs = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);
            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);

            var truckArgs = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Drive":
                        var distance = double.Parse(command[2]);
                        switch (command[1])
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(distance));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(distance));
                                break;
                        }
                        break;
                    case "Refuel":
                        var amount = double.Parse(command[2]);
                        switch (command[1])
                        {
                            case "Car":
                                car.Refuel(amount);
                                break;
                            case "Truck":
                                truck.Refuel(amount);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}

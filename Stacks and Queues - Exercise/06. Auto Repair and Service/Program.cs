using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsToServe = Console.ReadLine().Split();
            var carsToServeQueue = new Queue<string>(carsToServe);

            var servedCars = new Stack<string>();

            while (true)
            {
                var command = Console.ReadLine().Split("-");

                switch (command[0])
                {
                    case "Service":
                        if (carsToServeQueue.Any())
                        {
                            var servedCar = carsToServeQueue.Dequeue();
                            servedCars.Push(servedCar);
                            Console.WriteLine($"Vehicle {servedCar} got served.");
                        }
                        break;

                    case "CarInfo":
                        var carModelToCheck = command[1];
                        if (servedCars.Contains(carModelToCheck))
                        {
                            Console.WriteLine($"Served.");
                        }
                        else
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        break;

                    case "History":
                        Console.WriteLine(string.Join(", ", servedCars));
                        break;

                    case "End":
                        if (carsToServeQueue.Any())
                        {
                            Console.WriteLine($"Vehicles for service: {string.Join(", ", carsToServeQueue)}");
                        }
                        Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
                        return;
                }
            }
        }
    }
}

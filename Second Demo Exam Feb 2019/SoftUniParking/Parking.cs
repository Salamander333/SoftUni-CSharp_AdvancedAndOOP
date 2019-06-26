using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public static List<Car> Cars { get; set; }

        public static int Capacity { get; set; }

        public int Count => Cars.Count;

        public Parking(int capacity)
        {
            Capacity = capacity;
            Cars = new List<Car>();
        }

        public string AddCar(Car car)
        {
            if (Cars.Count > 0 && Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count() == Capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string regNum)
        {
            if (!Cars.Any(x => x.RegistrationNumber == regNum))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                var carToRemove = Cars.FindIndex(x => x.RegistrationNumber == regNum);
                Cars.RemoveAt(carToRemove);
                return $"Successfully removed {regNum}";
            }
        }

        public Car GetCar(string regNum)
        {
            var car = Cars.First(x => x.RegistrationNumber == regNum);
            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> regNums)
        {
            foreach (var num in regNums)
            {
                RemoveCar(num);
            }
        }
    }
}

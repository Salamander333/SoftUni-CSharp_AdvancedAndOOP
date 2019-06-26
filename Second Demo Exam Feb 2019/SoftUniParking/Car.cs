using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; private set; }

        public string Model { get; private set; }

        public int Horsepower { get; private set; }

        public string RegistrationNumber { get; private set; }

        public Car(string make, string model, int hp, string regNum)
        {
            Make = make;
            Model = model;
            Horsepower = hp;
            RegistrationNumber = regNum;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {Horsepower}");
            sb.Append($"RegistrationNumber: {RegistrationNumber}");

            return sb.ToString();
        }
    }
}

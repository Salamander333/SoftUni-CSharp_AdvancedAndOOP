using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Car_Salesman
{
    public class Car
    {
        public string Model { get; private set; }

        public Engine Engine { get; private set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a") { }
        public Car(string model, Engine engine, string color) : this(model, engine, -1, color) { }
        public Car(string model, Engine engine) : this(model, engine, -1, "n/a") { }

        public override string ToString()
        {
            var car = new StringBuilder();
            car.AppendLine($"{Model}:");
            car.AppendLine($"  {Engine.Model}:");
            car.AppendLine($"    Power: {Engine.Power}");

            if (Engine.Displacement > -1)
            {
                car.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            else
            {
                car.AppendLine($"    Displacement: n/a");
            }

            car.AppendLine($"    Efficiency: {Engine.Efficiency}");

            if (Weight > -1)
            {
                car.AppendLine($"  Weight: {Weight}");
            }
            else
            {
                car.AppendLine($"  Weight: n/a");
            }

            car.Append($"  Color: {Color}");

            return car.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm.Animals
{
    abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract void ProduceSound();

        public abstract void EatFood(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, "; 
        }
    }
}

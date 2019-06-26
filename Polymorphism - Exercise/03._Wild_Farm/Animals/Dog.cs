using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm.Animals
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                var weightIncrease = food.Quantity * 0.40;
                this.Weight += weightIncrease;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm.Animals
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                var weightIncrease = food.Quantity * 0.30;
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
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

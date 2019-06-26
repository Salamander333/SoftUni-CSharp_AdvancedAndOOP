using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm.Animals
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void EatFood(Food food)
        {
            var weightIncrease = food.Quantity * 0.35;
            this.Weight += weightIncrease;
            this.FoodEaten += food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm
{
    static class FoodFactory
    {
        public static Food ProduceFood(string[] args)
        {
            var type = args[0];
            var quantity = int.Parse(args[1]);

            switch (type)
            {
                case "Fruit":
                    return new Fruit(quantity);

                case "Meat":
                    return new Meat(quantity);

                case "Seeds":
                    return new Seeds(quantity);

                case "Vegetable":
                    return new Vegetable(quantity);

                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}

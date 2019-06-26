using System;
using System.Collections.Generic;

namespace _05._Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            var toppings = new List<Topping>();

            var pizzaInput = Console.ReadLine().Split();
            var pizzaName = pizzaInput[1];

            var doughInput = Console.ReadLine().Split();
            var flourType = doughInput[1].ToLower();
            var bakingTechnique = doughInput[2].ToLower();
            var doughWeightInGrams = int.Parse(doughInput[3]);
            var dough = new Dough(flourType, bakingTechnique, doughWeightInGrams);

            while (true)
            {
                var toppingInput = Console.ReadLine().Split();
                if (toppingInput[0] == "END")
                {
                    break;
                }

                var toppingType = toppingInput[1];
                var toppingWeightInGrams = int.Parse(toppingInput[2]);
                var topping = new Topping(toppingType, toppingWeightInGrams);
                toppings.Add(topping);
            }

            var pizza = new Pizza(pizzaName, dough, toppings);
            Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
        }
    }
}

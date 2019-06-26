using System;
using System.Collections.Generic;
using _03._Wild_Farm.Animals;
using _03._Wild_Farm.Foods;

namespace _03._Wild_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new List<Animal>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    foreach (var _animal in zoo)
                    {
                        Console.WriteLine(_animal.ToString());
                    }
                    return;
                }

                var animalArgs = input.Split();
                var animal = AnimalFactory.CreateAnimal(animalArgs);
                zoo.Add(animal);

                var foodInput = Console.ReadLine().Split();
                var food = FoodFactory.ProduceFood(foodInput);

                try
                {
                    animal.ProduceSound();
                    animal.EatFood(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); ;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using _03._Wild_Farm.Animals;

namespace _03._Wild_Farm
{
    static class AnimalFactory
    {
        public static Animal CreateAnimal(string[] args)
        {
            var type = args[0];
            var animalName = args[1];
            var animalWeight = double.Parse(args[2]);

            switch (type)
            {
                case "Cat":
                    return new Cat(animalName, animalWeight, args[3], args[4]);

                case "Tiger":
                    return new Tiger(animalName, animalWeight, args[3], args[4]);

                case "Owl":
                    return new Owl(animalName, animalWeight, double.Parse(args[3]));

                case "Hen":
                    return new Hen(animalName, animalWeight, double.Parse(args[3]));

                case "Mouse":
                    return new Mouse(animalName, animalWeight, args[3]);

                case "Dog":
                    return new Dog(animalName, animalWeight, args[3]);

                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
}

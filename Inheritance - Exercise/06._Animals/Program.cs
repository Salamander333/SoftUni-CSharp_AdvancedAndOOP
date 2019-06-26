using System;
using System.Collections.Generic;

namespace _06._Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Beast!")
                {
                    foreach (var animal in animals)
                    {
                        Console.WriteLine(animal.ToString());
                    }

                    break;
                }

                var type = input;
                var animalArgs = Console.ReadLine().Split();
                var animalName = animalArgs[0];
                var animalAge = int.Parse(animalArgs[1]);
                var animalGender = animalArgs[2];

                try
                {
                    switch (type)
                    {
                        case "Cat":
                            var cat = new Cat(animalName, animalAge, animalGender);
                            animals.Add(cat);
                            break;
                        case "Dog":
                            var dog = new Dog(animalName, animalAge, animalGender);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(animalName, animalAge, animalGender);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(animalName, animalAge);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(animalName, animalAge);
                            animals.Add(tomcat);
                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException message)
                {
                    Console.WriteLine(message.Message);
                }
            }
        }
    }
}

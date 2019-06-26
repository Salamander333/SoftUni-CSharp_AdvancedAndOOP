using System;
using System.Linq;

namespace _02._Baking_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int energy = 100;
            int coins = 100;

            foreach (string e in input)
            {
                string[] _event = e.Split("-");

                if (_event[1] == "")
                {
                    _event[1] = "0";
                }

                switch (_event[0])
                {
                    case "rest":
                        int energyToGain = int.Parse(_event[1]);
                        if (energy < 100)
                        {
                            if ((energy + energyToGain) > 100)
                            {
                                int es = 100 - energy;
                                energy = 100;
                                Console.WriteLine($"You gained {es} energy.");
                                Console.WriteLine($"Current energy: {energy}.");
                            }
                            if ((energy + energyToGain) <= 100)
                            {
                                energy += energyToGain;
                                Console.WriteLine($"You gained {energyToGain} energy.");
                                Console.WriteLine($"Current energy: {energy}.");
                            }
                        }
                        else if (energy == 100)
                        {
                            Console.WriteLine($"You gained 0 energy.");
                            Console.WriteLine($"Current energy: {energy}.");
                        }
                        break;
                    case "order":
                        if (energy >= 30)
                        {
                            energy -= 30;
                            coins += int.Parse(_event[1]);
                            Console.WriteLine($"You earned {_event[1]} coins.");
                        }
                        else
                        {
                            energy += 50;
                            Console.WriteLine("You had to rest!");
                        }
                        break;
                    default:
                        if (coins <= int.Parse(_event[1]))
                        {
                            Console.WriteLine($"Closed! Cannot afford {_event[0]}." );
                            return;
                        }
                        else
                        {
                            coins -= int.Parse(_event[1]);
                            Console.WriteLine($"You bought {_event[0]}.");
                        }
                        break;
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int passengerCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (command == "end")
                {
                    break;
                }

                switch (tokens[0])
                {
                    case "Add":
                        int wagonToAdd = int.Parse(tokens[1]);
                        wagonsInput.Add(wagonToAdd);
                        break;
                    default:
                        int passengersToAdd = int.Parse(tokens[0]);
                        for (int i = 0; i < wagonsInput.Count; i++)
                        {
                            if (wagonsInput[i] + passengersToAdd <= passengerCapacity)
                            {
                                wagonsInput[i] += passengersToAdd;
                                break;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", wagonsInput));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        input.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        input.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        input.RemoveAt(indexToRemoveAt);
                        break;
                    case "Insert":
                        int numberToAddAtIndex = int.Parse(tokens[1]);
                        int indexToAddAt = int.Parse(tokens[2]);
                        input.Insert(indexToAddAt, numberToAddAtIndex);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

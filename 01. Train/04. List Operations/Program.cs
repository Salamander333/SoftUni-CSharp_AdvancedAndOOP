using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
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
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        input.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToAddAtIndex = int.Parse(command[1]);
                        int numberIndex = int.Parse(command[2]);
                        if (numberIndex > input.Count - 1 || numberIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        input.Insert(numberIndex, numberToAddAtIndex);
                        break;
                    case "Remove":
                        int removeAtIndex = int.Parse(command[1]);
                        if (removeAtIndex > input.Count - 1 || removeAtIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        input.RemoveAt(removeAtIndex);
                        break;
                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    int fistNum = input.First();
                                    input.Remove(input.First());
                                    input.Add(fistNum);
                                }
                                break;
                            case "right":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    int lastNum = input.Last();
                                    input.Remove(input.Last());
                                    input.Insert(0, lastNum);
                                }
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool changed = false;

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
                        changed = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        input.Remove(numberToRemove);
                        changed = true;
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        input.RemoveAt(indexToRemoveAt);
                        changed = true;
                        break;

                    case "Insert":
                        int numberToAddAtIndex = int.Parse(tokens[1]);
                        int indexToAddAt = int.Parse(tokens[2]);
                        input.Insert(indexToAddAt, numberToAddAtIndex);
                        changed = true;
                        break;

                    case "Contains":
                        int numberToContain = int.Parse(tokens[1]);
                        bool contains = false;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == numberToContain)
                            {
                                contains = true;
                            }
                        }
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> listOfEvens = new List<int>();
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0)
                            {
                                listOfEvens.Add(input[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", listOfEvens));
                        break;

                    case "PrintOdd":
                        List<int> listOfOdds = new List<int>();
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 1)
                            {
                                listOfOdds.Add(input[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", listOfOdds));
                        break;

                    case "GetSum":
                        int sum = 0;
                        foreach (int n in input)
                        {
                            sum += n;
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        int numToFilter = int.Parse(tokens[2]);
                        switch (tokens[1])
                        {
                            case "<":
                                foreach (int n in input)
                                {
                                    if (n < numToFilter)
                                    {
                                        Console.Write(n + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                foreach (int n in input)
                                {
                                    if (n > numToFilter)
                                    {
                                        Console.Write(n + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (int n in input)
                                {
                                    if (n <= numToFilter)
                                    {
                                        Console.Write(n + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (int n in input)
                                {
                                    if (n >= numToFilter)
                                    {
                                        Console.Write(n + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }
            if (changed)
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}

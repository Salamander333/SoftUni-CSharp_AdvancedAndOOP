using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Grains_of_Sands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Mort")
                {
                    break;
                }
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        numList.Add(int.Parse(command[1]));
                        break;

                    case "Remove":
                        int valueToRemove = int.Parse(command[1]);

                        for (int i = 0; i < numList.Count; i++)
                        {
                            if (numList[i] == valueToRemove)
                            {
                                numList.RemoveAt(i);
                                break;
                            }
                            else
                            {
                                if (valueToRemove < numList.Count)
                                {
                                    numList.RemoveAt(valueToRemove);
                                    break;
                                }
                            }
                        }
                        break;

                    case "Replace":
                        int valueToReplace = int.Parse(command[1]);
                        int valueReplacement = int.Parse(command[2]);
                        for (int i = 0; i < numList.Count; i++)
                        {
                            if (numList[i] == valueToReplace)
                            {
                                numList[i] = valueReplacement;
                                break;
                            }
                        }
                        break;

                    case "Increase":
                        int valueToIncrease = int.Parse(command[1]);

                        for (int i = 0; i < numList.Count; i++)
                        {
                            if (numList[i] >= valueToIncrease)
                            {
                                valueToIncrease = numList[i];
                                break;
                            }
                            else
                            {
                                valueToIncrease = numList.Last();
                                break;
                            }
                        }
                        for (int i = 0; i < numList.Count; i++)
                        {
                            numList[i] += valueToIncrease;
                        }
                        break;

                    case "Collapse":
                        int removeEachLessThan = int.Parse(command[1]);
                        numList.RemoveAll(x => x < removeEachLessThan);
                        break;
                }

            }

            foreach (var item in numList)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}

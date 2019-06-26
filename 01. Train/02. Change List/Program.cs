using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
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
                string[] commandTokens = command.Split();

                if (command == "end")
                {
                    break;
                }

                switch (commandTokens[0])
                {
                    case "Delete":
                        int elementToDelete = int.Parse(commandTokens[1]);
                        input.RemoveAll(x => x == elementToDelete);
                        break;

                    case "Insert":
                        int indexValue = int.Parse(commandTokens[1]);
                        int index = int.Parse(commandTokens[2]);
                        input.Insert(index, indexValue);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

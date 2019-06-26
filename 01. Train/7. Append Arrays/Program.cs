using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|")
                .ToList();

            List<int> result = new List<int>();

            input.Reverse();

            foreach (string str in input)
            {
                List<int> numbersInArray = str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (int n in numbersInArray)
                {
                    result.Add(n);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

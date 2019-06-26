using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                int resultToAdd = input[i] + input[input.Count - 1 - i];
                result.Add(resultToAdd);
            }
            if (input.Count % 2 == 1)
            {
                result.Add(input[input.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

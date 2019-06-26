using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> cast = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int numberToBomb = cast[0];
            int bombPower = cast[1];

            int startIndex = 0;
            int endIndex = 0;

            if (bombPower >= 0 && bombPower < input.Count)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == numberToBomb)
                    {
                        if (i - bombPower < 0)
                        {
                            startIndex = 0;
                        }
                        else
                        {
                            startIndex = i - bombPower;
                        }
                        if (i + bombPower >= input.Count)
                        {
                            endIndex = input.Count - 1;
                        }
                        else
                        {
                            endIndex = i + bombPower;
                        }

                        for (int j = endIndex; j >= startIndex; j--)
                        {
                            input.RemoveAt(j);
                        }
                        i = 0;
                    }
                }
            }

            int sum = 0;
            foreach (int n in input)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}

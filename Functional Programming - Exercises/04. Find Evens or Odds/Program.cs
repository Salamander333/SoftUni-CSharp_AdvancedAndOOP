using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var command = Console.ReadLine().ToLower();

            var numList = new List<long>();

            for (long i = range[0]; i <= range[1]; i++)
            {
                numList.Add(i);
            }

            switch (command)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", numList.Where(x => x % 2 != 0)));
                    break;

                case "even":
                    Console.WriteLine(string.Join(" ", numList.Where(x => x % 2 == 0)));
                    break;
            }

        }
    }
}

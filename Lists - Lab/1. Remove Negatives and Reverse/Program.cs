using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            input.RemoveAll(n => n < 0);

            if (input.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}

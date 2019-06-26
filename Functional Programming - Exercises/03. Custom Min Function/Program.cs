using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> result = x => x.Min();

            Console.WriteLine(result(nums));
        }
    }
}

using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x % 2 != 0).ThenBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            var divideBy = int.Parse(Console.ReadLine());

            input = input.Where(x => x % divideBy != 0).ToList();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

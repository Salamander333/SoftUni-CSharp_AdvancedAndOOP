using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArray = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double n in doubleArray)
            {
                Console.WriteLine($"{n} => {Math.Round(n, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

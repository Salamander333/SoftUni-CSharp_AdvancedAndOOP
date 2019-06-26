using System;
using System.Linq;

namespace _04._Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            var stones = new Lake(input);

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}

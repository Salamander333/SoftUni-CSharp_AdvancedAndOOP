using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> result = name => Console.WriteLine($"Sir {name}");

            foreach (var name in input)
            {
                result(name);
            }
        }
    }
}

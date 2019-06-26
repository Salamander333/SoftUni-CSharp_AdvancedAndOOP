using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            Action<string> print = message => Console.WriteLine(message);

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}

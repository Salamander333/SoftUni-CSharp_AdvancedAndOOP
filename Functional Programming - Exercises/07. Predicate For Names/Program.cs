using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNameLenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            names = names.Where(x => x.Length <= maxNameLenght).ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

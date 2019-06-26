using System;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().Where(x => x.Sum(y => y) >= sum).FirstOrDefault();

            Console.WriteLine(names);
        }
    }
}

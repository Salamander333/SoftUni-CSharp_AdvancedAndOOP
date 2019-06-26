using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }

            foreach (var item in elements)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRows = int.Parse(Console.ReadLine());

            var nameHashSet = new HashSet<string>();

            for (int i = 0; i < inputRows; i++)
            {
                var name = Console.ReadLine();

                nameHashSet.Add(name);
            }

            foreach (var name in nameHashSet)
            {
                Console.WriteLine(name);
            }
        }
    }
}

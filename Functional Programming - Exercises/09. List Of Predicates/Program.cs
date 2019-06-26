using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsUpperBound = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            var nums = new List<int>();

            for (int i = 1; i <= numsUpperBound; i++)
            {
                nums.Add(i);
            }

            foreach (var divider in dividers)
            {
                Predicate<int> temp = x => x % divider == 0;
                predicates.Add(temp);
            }

            foreach (var predicate in predicates)
            {
                nums = nums.FindAll(predicate);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

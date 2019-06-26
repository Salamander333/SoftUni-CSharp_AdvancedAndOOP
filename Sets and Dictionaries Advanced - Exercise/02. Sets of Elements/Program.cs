using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setLenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = setLenghts[0];
            var m = setLenghts[1];

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            var repeatingNums = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var nNums = int.Parse(Console.ReadLine());
                nSet.Add(nNums);
            }

            for (int i = 0; i < m; i++)
            {
                var mNums = int.Parse(Console.ReadLine());
                mSet.Add(mNums);
            }

            foreach (var num in nSet)
            {
                if (mSet.Contains(num))
                {
                    repeatingNums.Add(num);
                }
            }

            foreach (var item in repeatingNums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

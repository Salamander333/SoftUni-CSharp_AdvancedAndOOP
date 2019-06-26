using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Generic_Swap_Method_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var b = new Box<int>(input);
                list.Add(b);
            }

            var indexesToSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list = Swap(list, indexesToSwap);

            foreach (var box in list)
            {
                Console.WriteLine(box);
            }
        }

        public static List<Box<int>> Swap(List<Box<int>> _boxes, int[] indexes)
        {
            var boxes = _boxes;
            var firstBox = boxes[indexes[0]];
            var secondBox = boxes[indexes[1]];
            boxes[indexes[0]] = secondBox;
            boxes[indexes[1]] = firstBox;
            return boxes;
        }
    }
}

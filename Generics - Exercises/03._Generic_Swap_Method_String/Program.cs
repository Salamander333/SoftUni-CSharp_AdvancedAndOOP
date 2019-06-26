using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Generic_Swap_Method_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var b = new Box<string>(input);
                list.Add(b);
            }

            var indexesToSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list = Swap(list, indexesToSwap);

            foreach (var box in list)
            {
                Console.WriteLine(box);
            }
        }

        public static List<Box<string>> Swap(List<Box<string>> _boxes, int[] indexes)
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

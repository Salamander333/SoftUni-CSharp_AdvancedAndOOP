using System;
using System.Collections.Generic;

namespace _06._Generic_Count_Method_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            var box = new Box<double>(list);
            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GreaterElementCount(element));
        }
    }
}

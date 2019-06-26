using System;
using System.Collections.Generic;

namespace _05._Generic_Count_Method_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                list.Add(input);
            }

            var box = new Box<string>(list);
            var element = Console.ReadLine();

            Console.WriteLine(box.GreaterElementCount(element));
        }
    }
}

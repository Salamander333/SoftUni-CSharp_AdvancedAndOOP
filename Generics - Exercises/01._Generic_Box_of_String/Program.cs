using System;
using System.Collections.Generic;

namespace _01._Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var b = new Box<string>(input);
                Console.WriteLine(b);
            }
        }
    }
}

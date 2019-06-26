using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var q = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    q.Enqueue(input);
                }
                else
                {
                    while (q.Any())
                    {
                        Console.WriteLine(q.Dequeue());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{q.Count} people remaining.");
        }
    }
}

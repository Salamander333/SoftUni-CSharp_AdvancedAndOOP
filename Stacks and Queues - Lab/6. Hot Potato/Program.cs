using System;
using System.Collections.Generic;

namespace _6._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int nth = int.Parse(Console.ReadLine());

            var q = new Queue<string>(input);

            int counter = 1;

            while (q.Count > 1)
            {
                var holder = q.Dequeue();
                if (counter == nth)
                {
                    Console.WriteLine($"Removed {holder}");
                    counter = 1;
                }
                else
                {
                    q.Enqueue(holder);
                    counter++;
                }

            }

            Console.WriteLine($"Last is {q.Dequeue()}");
        }
    }
}

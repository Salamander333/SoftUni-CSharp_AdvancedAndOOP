using System;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int lightCapacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var q = new Queue<string>();
            int passedCars = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < lightCapacity; i++)
                    {
                        if (q.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{q.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    q.Enqueue(input);
                }
                input = Console.ReadLine();

            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}

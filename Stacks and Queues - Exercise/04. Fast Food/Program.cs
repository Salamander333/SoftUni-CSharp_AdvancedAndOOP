using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var orderQueue = new Queue<int>(orders);

            Console.WriteLine(orderQueue.Max());

            while (orderQueue.Any())
            {
                var order = orderQueue.Peek();
                if (foodQuantity >= order)
                {
                    orderQueue.Dequeue();
                    foodQuantity -= order;
                }
                else
                {
                    var s = string.Join(" ", orderQueue);
                    Console.WriteLine($"Orders left: {s}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}

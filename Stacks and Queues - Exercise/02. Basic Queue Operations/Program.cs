using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numsToQueue = input[0];
            int numsToDequeue = input[1];
            int numToLookFor = input[2];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numQueue = new Queue<int>(nums);

            for (int i = 0; i < numsToDequeue; i++)
            {
                numQueue.Dequeue();
            }

            foreach (var item in numQueue)
            {
                if (item == numToLookFor)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (numQueue.Any())
            {
                Console.WriteLine(numQueue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var pushCount = input[0];
            var popCount = input[1];
            var numToPeek = input[2];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numStack = new Stack<int>();

            for (int i = 0; i < pushCount; i++)
            {
                numStack.Push(nums[i]);
            }

            for (int i = 0; i < popCount; i++)
            {
                numStack.Pop();
            }

            foreach (var item in numStack)
            {
                if (item == numToPeek)
                {
                    Console.WriteLine("true");
                    return;
                }
            }


            if (numStack.Any())
            {
                int smallestStackValue = numStack.Min();
                Console.WriteLine(smallestStackValue);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

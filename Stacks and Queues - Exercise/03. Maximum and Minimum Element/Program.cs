using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int querieCount = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < querieCount; i++)
            {
                int[] querie = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = querie[0];

                switch (command)
                {
                    case 1:
                        int numToPush = querie[1];
                        stack.Push(numToPush);
                        break;
                    case 2:
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

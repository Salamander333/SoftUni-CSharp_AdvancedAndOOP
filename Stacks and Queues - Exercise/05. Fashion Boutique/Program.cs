using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var box = new Stack<int>(clothes);

            var rackCapacity = int.Parse(Console.ReadLine());

            var sum = box.Pop(); ;
            var rackCount = 1;

            while (box.Any())
            {
                var n = box.Peek();
                sum += n;

                if (sum < rackCapacity)
                {
                    box.Pop();
                }
                else if (sum == rackCapacity)
                {
                    box.Pop();
                    sum = 0;
                    if (box.Any())
                    {
                        rackCount++;
                    }
                }
                else if (sum > rackCapacity)
                {
                    sum = 0;
                    rackCount++;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}

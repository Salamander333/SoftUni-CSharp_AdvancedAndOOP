using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int previousSum = 0;
            int diffirence = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousSum = num1 + num2;
                }
                else
                {
                    currentSum = num1 + num2;
                    diffirence = Math.Abs(previousSum - currentSum);
                    if (diffirence > maxDiff)
                    {
                        maxDiff = diffirence;
                    }
                    previousSum = currentSum;
                }
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value=" + previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
        }
    }
}

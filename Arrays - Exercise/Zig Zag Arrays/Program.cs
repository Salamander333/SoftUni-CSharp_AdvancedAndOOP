using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberOfInputLines];
            int[] secondArray = new int[numberOfInputLines];

            for (int i = 0; i < numberOfInputLines; i++)
            {
                if (i % 2 == 0)
                {
                    int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    firstArray[i] = inputLine[0];
                    secondArray[i] = inputLine[1];
                }
                else
                {
                    int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    firstArray[i] = inputLine[1];
                    secondArray[i] = inputLine[0];
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[dimentions[0], dimentions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] intInputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = intInputLine[col];
                }
            }

            var maxSum = 0;
            var maxSubMatrix = new int[3, 3];
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = 0;
                    var subMatrix = new int[3, 3];

                    for (int subRow = 0; subRow < 3; subRow++)
                    {
                        for (int subCol = 0; subCol < 3; subCol++)
                        {
                            subMatrix[subRow, subCol] = matrix[row + subRow, col + subCol];
                        }
                    }

                    foreach (var n in subMatrix)
                    {
                        currentSum += n;
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSubMatrix = subMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(maxSubMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

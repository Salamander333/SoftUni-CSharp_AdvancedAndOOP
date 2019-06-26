using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var matrix = new int[dimentions[0], dimentions[1]];
            var biggestSubMatrix = new int[2, 2];
            var biggestSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowNums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowNums[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var currentSubMatrixSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row, col + 1];
                    if (currentSubMatrixSum > biggestSum)
                    {
                        biggestSubMatrix[0, 0] = matrix[row, col];
                        biggestSubMatrix[0, 1] = matrix[row, col + 1];
                        biggestSubMatrix[1, 0] = matrix[row + 1, col];
                        biggestSubMatrix[1, 1] = matrix[row + 1, col + 1];
                        biggestSum = currentSubMatrixSum;
                    }
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{biggestSubMatrix[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}

using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            var matrix = new int[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                var rowNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < dimentions; col++)
                {
                    matrix[row, col] = rowNums[col];
                }
            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int row = 0; row < dimentions; row++)
            {
                primaryDiagonalSum += matrix[row, row];

                secondaryDiagonalSum += matrix[row, dimentions - 1 - row];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}

using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                int[] rowNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < dimentions; col++)
                {
                    matrix[row, col] = rowNums[col];
                }
            }

            var sum = 0;

            for (int i = 0; i < dimentions; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Linq;

namespace _4._Matrix_shuffling
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

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] != "swap" || input.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    var row1 = int.Parse(input[1]);
                    var col1 = int.Parse(input[2]);
                    var row2 = int.Parse(input[3]);
                    var col2 = int.Parse(input[4]);

                    if (row1 > dimentions[0] - 1 ||
                        row1 < 0 ||
                        row2 > dimentions[0] - 1 ||
                        row2 < 0 ||
                        col1 > dimentions[1] - 1 ||
                        col1 < 0 ||
                        col2 > dimentions[1] - 1 ||
                        col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    int saveValue = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = saveValue;

                    for (int row = 0; row < dimentions[0]; row++)
                    {
                        for (int col = 0; col < dimentions[1]; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

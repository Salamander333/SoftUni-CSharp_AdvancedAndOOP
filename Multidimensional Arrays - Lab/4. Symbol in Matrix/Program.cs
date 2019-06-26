using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            var matrix = new char[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                char[] charsOnRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < dimentions; col++)
                {
                    matrix[row, col] = charsOnRow[col];
                }
            }

            char charToLookFor = char.Parse(Console.ReadLine());
            for (int row = 0; row < dimentions; row++)
            {
                for (int col = 0; col < dimentions; col++)
                {
                    if (matrix[row, col] == charToLookFor)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{charToLookFor} does not occur in the matrix");
        }
    }
}

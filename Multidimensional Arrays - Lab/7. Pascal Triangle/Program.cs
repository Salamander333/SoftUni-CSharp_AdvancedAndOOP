using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[n][];
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new long[row + 1];
                if (jaggedArray[row].Length <= 2)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] = 1;

                    }
                }
                if (jaggedArray[row].Length > 2)
                {
                    jaggedArray[row][0] = 1;
                    jaggedArray[row][row] = 1;
                    for (int i = 1; i < jaggedArray[row].Length - 1; i++)
                    {
                        long[] previousRow = jaggedArray[row - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        jaggedArray[row][i] = previousRowSum;
                    }
                }
            }

            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

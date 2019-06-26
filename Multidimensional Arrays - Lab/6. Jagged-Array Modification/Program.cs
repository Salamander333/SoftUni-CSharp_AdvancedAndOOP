using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedArrayLenght = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[jaggedArrayLenght][];

            for (int row = 0; row < jaggedArrayLenght; row++)
            {
                int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[inputNums.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = inputNums[col];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                var command = input[0];


                if (command == "END")
                {
                    break;
                }
                else if (command == "Add")
                {
                    var row = int.Parse(input[1]);
                    var col = int.Parse(input[2]);
                    var value = int.Parse(input[3]);

                    if (row < jaggedArray.Length && row >= 0 && col < jaggedArray[row].Length && col >= 0)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command == "Subtract")
                {
                    var row = int.Parse(input[1]);
                    var col = int.Parse(input[2]);
                    var value = int.Parse(input[3]);

                    if (row < jaggedArray.Length && row >= 0 && col < jaggedArray[row].Length && col >= 0)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

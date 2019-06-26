using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[dimentions[0], dimentions[1]];

            string snake = Console.ReadLine();
            var snakeQueue = new Queue<char>(snake);

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    var c = snakeQueue.Dequeue();
                    matrix[row, col] = c;
                    snakeQueue.Enqueue(c);
                }
            }

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    Console.Write((char)matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

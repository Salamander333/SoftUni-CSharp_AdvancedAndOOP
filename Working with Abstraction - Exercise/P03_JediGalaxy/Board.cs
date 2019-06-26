using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    class Board
    {
        public Board(int h, int w)
        {
            this.Matrix = new int[h, w];
            this.InitializeBoard();
        }

        public int Height { get; private set; }

        public int Width { get; private set; }

        public int[,] Matrix { get; private set; }

        private void InitializeBoard()
        {
            int counter = 0;

            for (int row = 0; row < this.Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.Matrix.GetLength(1); col++)
                {
                    Matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        public bool IsInside(int row, int col)
        {
            if (row >= 0 && row < Matrix.GetLength(0))
            {
                if (col >= 0 && col < Matrix.GetLength(1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

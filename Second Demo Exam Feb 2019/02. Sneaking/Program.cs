using System;
using System.Linq;

namespace _02._Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardDimentions = int.Parse(Console.ReadLine());
            char[] line = Console.ReadLine().ToCharArray();
            var board = new char[boardDimentions][];
            for (int i = 0; i < boardDimentions; i++)
            {
                board[i] = new char[line.Length];
            }

            for (int i = 0; i < boardDimentions; i++)
            {
                for (int j = 0; j < line.Length; j++)
                {
                    board[i][j] = line[j];
                }
                if (i != boardDimentions - 1)
                {
                    line = Console.ReadLine().ToCharArray();

                }
            }

            var moves = Console.ReadLine().ToCharArray();
            foreach (var move in moves)
            {
                //EnemyMove();
                for (int row = 0; row < board.Length; row++)
                {
                    int enemyRow = -1;
                    int enemyCol = -1;
                    string dir = "";
                    for (int col = 0; col < board[row].Length; col++)
                    {
                        if (board[row][col] == 'b')
                        {
                            enemyRow = row;
                            enemyCol = col;
                            dir = "right";
                            break;
                        }
                        else if (board[row][col] == 'd')
                        {
                            enemyRow = row;
                            enemyCol = col;
                            dir = "left";
                            break;
                        }
                    }
                    switch (dir)
                    {
                        case "left":
                            if (enemyCol == 0)
                            {
                                board[enemyRow][enemyCol] = 'b';
                            }
                            else
                            {
                                board[enemyRow][enemyCol] = '.';
                                board[enemyRow][enemyCol - 1] = 'd';
                            }
                            break;
                        case "right":
                            if (enemyCol == board[enemyRow].Length - 1)
                            {
                                board[enemyRow][enemyCol] = 'd';
                            }
                            else
                            {
                                board[enemyRow][enemyCol] = '.';
                                board[enemyRow][enemyCol + 1] = 'b';
                            }
                            break;
                    }
                }

                //CheckIfPlayerDies();
                for (int row = 0; row < board.Length; row++)
                {
                    for (int col = 0; col < board[row].Length; col++)
                    {
                        if (board[row][col] == 'S')
                        {
                            //if we find the row with sam
                            //we check if any of the enemies face him
                            for (int i = 0; i < board[row].Length; i++)
                            {
                                if (board[row][i] == 'b')
                                {
                                    for (int j = i; j < board[row].Length; j++)
                                    {
                                        if (board[row][j] == 'S')
                                        {
                                            board[row][j] = 'X';
                                            PrintResult($"Sam died at {row}, {col}", board);
                                            return;
                                        }
                                    }
                                }
                                else if (board[row][i] == 'd')
                                {
                                    for (int j = i; j >= 0; j--)
                                    {
                                        if (board[row][j] == 'S')
                                        {
                                            board[row][j] = 'X';
                                            PrintResult($"Sam died at {row}, {col}", board);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //MoveSam();
                int samRow = -1;
                int samCol = -1;
                for (int row = 0; row < board.Length; row++)
                {
                    for (int col = 0; col < board[row].Length; col++)
                    {
                        if (board[row][col] == 'S')
                        {
                            samRow = row;
                            samCol = col;
                        }
                    }
                }
                switch (move)
                {
                    case 'U':
                        board[samRow][samCol] = '.';
                        board[samRow - 1][samCol] = 'S';
                        break;
                    case 'D':
                        board[samRow][samCol] = '.';
                        board[samRow + 1][samCol] = 'S';
                        break;
                    case 'L':
                        board[samRow][samCol] = '.';
                        board[samRow][samCol - 1] = 'S';
                        break;
                    case 'R':
                        board[samRow][samCol] = '.';
                        board[samRow][samCol + 1] = 'S';
                        break;
                }

                //WinCondition();
                samRow = -1;
                samCol = -1;
                for (int row = 0; row < board.Length; row++)
                {
                    for (int col = 0; col < board[row].Length; col++)
                    {
                        if (board[row][col] == 'S')
                        {
                            samRow = row;
                            samCol = col;
                            for (int i = 0; i < board[row].Length; i++)
                            {
                                if (board[row][i] == 'N')
                                {
                                    board[row][i] = 'X';
                                    PrintResult("Nikoladze killed!", board);
                                    return;
                                }
                            }
                        }
                    }
                }

            }
        }

        public static void PrintResult(string message, char[][] board)
        {
            Console.WriteLine(message);
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    Console.Write(board[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

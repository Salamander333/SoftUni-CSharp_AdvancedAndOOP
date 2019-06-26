using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimestions[0];
            int cols = dimestions[1];

            var board = new Board(rows, cols);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoArgs = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilArgs = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int evilRow = evilArgs[0];
                int evilCol = evilArgs[1];
                var evil = new Entity(evilRow, evilCol);


                while (evil.Row >= 0 && evil.Col >= 0)
                {
                    if (board.IsInside(evil.Row, evil.Col))
                    {
                        board.Matrix[evil.Row, evil.Col] = 0;
                    }

                    evil.Row--;
                    evil.Col--;
                }

                int ivoRow = ivoArgs[0];
                int ivoCol = ivoArgs[1];
                var ivo = new Entity(ivoRow, ivoCol);

                while (ivo.Row >= 0 && ivo.Col < board.Matrix.GetLength(1))
                {
                    if (board.IsInside(ivo.Row, ivo.Col))
                    {
                        sum += board.Matrix[ivo.Row, ivo.Col];
                    }

                    ivo.Row--;
                    ivo.Col++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }
    }
}

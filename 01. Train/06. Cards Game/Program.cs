using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            string winner;
            int winnerSum = 0;

            while (true)
            {
                if (playerOneHand.Count == 0)
                {
                    winner = "Second player wins!";
                    foreach (int n in playerTwoHand)
                    {
                        winnerSum += n;
                    }
                    break;
                }
                else if(playerTwoHand.Count == 0)
                {
                    winner = "First player wins!";
                    foreach (int n in playerOneHand)
                    {
                        winnerSum += n;
                    }
                    break;
                }

                int playerOnePlay = playerOneHand[0];
                int playerTwoPlay = playerTwoHand[0];

                if (playerOnePlay > playerTwoPlay)
                {
                    playerOneHand.RemoveAt(0);
                    playerTwoHand.RemoveAt(0);
                    playerOneHand.Add(playerOnePlay);
                    playerOneHand.Add(playerTwoPlay);
                }
                else if (playerTwoPlay > playerOnePlay)
                {
                    playerOneHand.RemoveAt(0);
                    playerTwoHand.RemoveAt(0);
                    playerTwoHand.Add(playerTwoPlay);
                    playerTwoHand.Add(playerOnePlay);
                }
                else if(playerOnePlay == playerTwoPlay)
                {
                    playerOneHand.RemoveAt(0);
                    playerTwoHand.RemoveAt(0);
                }
            }
            Console.WriteLine($"{winner} Sum: {winnerSum}");
        }
    }
}

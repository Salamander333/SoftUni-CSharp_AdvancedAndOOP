using System;

namespace _01._Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int initialPresents = int.Parse(Console.ReadLine());

            int timesWentBack = 0;
            int visitedHomes = 0;
            int remainingPresents = initialPresents;
            int additionalPresentsTaken = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                visitedHomes++;
                int remainingHomes = homesToVisit - visitedHomes;

                int childrenPerHouse = int.Parse(Console.ReadLine());

                remainingPresents = remainingPresents - childrenPerHouse;
                if (remainingPresents < 0)
                {
                    int additionalPresents = Math.Abs(remainingPresents);
                    timesWentBack++;
                    remainingPresents = (initialPresents / visitedHomes) * remainingHomes + additionalPresents;
                    additionalPresentsTaken += remainingPresents;
                    remainingPresents -= additionalPresents;
                }

                if (i == homesToVisit)
                {
                    if (timesWentBack > 0)
                    {
                        Console.WriteLine($"{timesWentBack}");
                        Console.WriteLine($"{additionalPresentsTaken}");
                    }
                    else
                    {
                        Console.WriteLine($"{remainingPresents}");
                    }
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Baking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestBatchSum = -1000;
            List<int> bestBatch = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Bake It!")
                {
                    break;
                }

                List<int> inputNums = input.Split("#", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int currentBatchSum = 0;
                foreach (int q in inputNums)
                {
                    currentBatchSum += q;
                }
                if (currentBatchSum > bestBatchSum)
                {
                    bestBatchSum = currentBatchSum;
                    bestBatch.Clear();
                    foreach (int i in inputNums)
                    {
                        bestBatch.Add(i);
                    }
                }
                if (currentBatchSum == bestBatchSum)
                {
                    if (bestBatch.Any())
                    {
                        double averageQualityOfBest = bestBatch.Average();
                        double averageQualityOfCurrent = inputNums.Average();

                        if (averageQualityOfCurrent > averageQualityOfBest)
                        {
                            bestBatch.Clear();
                            foreach (int i in inputNums)
                            {
                                bestBatch.Add(i);
                            }
                        }
                        if (averageQualityOfCurrent == averageQualityOfBest)
                        {
                            if (inputNums.Count < bestBatch.Count)
                            {
                                bestBatch.Clear();
                                foreach (int i in inputNums)
                                {
                                    bestBatch.Add(i);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {bestBatchSum}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}

using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine());

            int bestSequenceLenght = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            string dnaSequence = string.Empty;
            int bestDnaSampleCount = 1;

            int currSequenceLenght = 0;
            int currStartingIndex = 0;
            bool isInSequence = false;

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split('!', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Clone them")
                {
                    break;
                }

                for (int i = 0; i < sequenceLenght; i++)
                {
                    if (input[i] == "1")
                    {
                        currSequenceLenght++;
                        if (!isInSequence)
                        {
                            isInSequence = true;
                            currStartingIndex = i;
                        }

                    }
                    else if (input[i] == "0")
                    {
                        if (currSequenceLenght >= bestSequenceLenght)
                        {
                            int curSequenceSum = 0;
                            string curDnaSequence;
                            for (int j = 0; j < sequenceLenght; j++)
                            {
                                if (input[j] == "1")
                                {
                                    curSequenceSum++;
                                    curDnaSequence = input[j] + " ";
                                }
                            }
                            if (curSequenceSum > bestSequenceSum)
                            {
                                bestSequenceSum = curSequenceSum;
                                curDnaSequence = dnaSequence;

                            }

                            if (currSequenceLenght == bestSequenceLenght)
                            {
                                bestDnaSampleCount++;
                            }
                            bestSequenceLenght = currSequenceLenght;
                            bestSequenceIndex = currStartingIndex;
                            isInSequence = false;
                        }

                        currSequenceLenght = 0;
                    }
                    if (i == sequenceLenght - 1)
                    {
                        int curSequenceSum = 0;
                        string curDnaSequence;
                        for (int j = 0; j < sequenceLenght; j++)
                        {
                            if (input[j] == "1")
                            {
                                curSequenceSum++;
                                curDnaSequence = input[j] + " ";
                            }
                        }
                        if (curSequenceSum > bestSequenceSum)
                        {
                            bestSequenceSum = curSequenceSum;
                            curDnaSequence = dnaSequence;

                        }

                        if (currSequenceLenght >= bestSequenceLenght)
                        {
                            if (currSequenceLenght == bestSequenceLenght)
                            {
                                bestDnaSampleCount++;
                            }

                            bestSequenceLenght = currSequenceLenght;
                            bestSequenceIndex = currStartingIndex;
                            isInSequence = false;
                        }
                        currSequenceLenght = 0;
                    }

                }
            }
            Console.WriteLine(bestSequenceLenght);
            Console.WriteLine(bestSequenceIndex);
            Console.WriteLine(bestDnaSampleCount);
            Console.WriteLine();
            Console.WriteLine(dnaSequence);
            Console.WriteLine(bestSequenceSum);
        }

    }
}

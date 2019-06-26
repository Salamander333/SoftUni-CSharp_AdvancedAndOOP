using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLenght = 1;
            int maxLenghtNum = 0;

            int curLenght = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    curLenght++;
                    if (curLenght > maxLenght)
                    {
                        maxLenght = curLenght;
                        maxLenghtNum = numbers[i];
                    }
                }
                else
                {
                    curLenght = 1;
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(maxLenghtNum + " ");
            }
        }
    }
}

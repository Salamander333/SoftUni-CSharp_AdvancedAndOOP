using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            int[] inputArray = new int[inputLines];

            for (int i = 0; i < inputLines; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = inputLines - 1; i >= 0; i--)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}

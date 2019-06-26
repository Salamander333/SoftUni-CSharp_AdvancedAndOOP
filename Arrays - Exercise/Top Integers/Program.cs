using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                int firstNumber = intArray[i];

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    int secondNumber = intArray[j];

                    if (firstNumber <= secondNumber)
                    {
                        break;
                    }
                    else if (j == intArray.Length - 1)
                    {
                        Console.Write(firstNumber + " ");
                    }
                }
            }
            Console.WriteLine(intArray[intArray.Length - 1]);
        }
    }
}

using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int firstNumber = intArray[0];

                for (int j = 0; j < intArray.Length - 1; j++)
                {
                    intArray[j] = intArray[j + 1];
                }

                intArray[intArray.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}

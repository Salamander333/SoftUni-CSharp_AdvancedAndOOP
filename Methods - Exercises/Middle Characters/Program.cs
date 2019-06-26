using System;
using System.Linq;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacer(input);
        }

        static void PrintMiddleCharacer(string input)
        {
            int midIndex = (input.Length - 1) / 2;
            int nextIndex = midIndex + 1;

            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input[midIndex].ToString() + input[nextIndex].ToString());
            }
            else
            {
                Console.WriteLine(input[midIndex]);
            }
        }
    }
}

using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                PrintLine(i);
            }
            for (int i = input - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
  
        static void PrintLine(int end, int start = 1)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

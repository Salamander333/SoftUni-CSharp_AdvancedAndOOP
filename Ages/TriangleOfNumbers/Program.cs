using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 1;

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b <= i; b++)
                {
                    Console.Write($"{temp} ");
                }
                temp++;
                Console.WriteLine();
            }
        }
    }
}

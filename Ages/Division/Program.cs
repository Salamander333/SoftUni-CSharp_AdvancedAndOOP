using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = 0;

            if (input % 2 == 0)
            {
                output = 2;
            }
            if (input % 3 == 0)
            {
                output = 3;
            }
            if (input % 6 == 0)
            {
                output = 6;
            }
            if (input % 7 == 0)
            {
                output = 7;
            }
            if (input % 10 == 0)
            {
                output = 10;
            }
            if (output != 0)
            {
                Console.WriteLine($"The number is divisible by {output}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}

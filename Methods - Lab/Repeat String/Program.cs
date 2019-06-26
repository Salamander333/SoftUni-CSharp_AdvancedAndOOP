using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int timeToRepeat = int.Parse(Console.ReadLine());

            Print(str, timeToRepeat);
        }

        static void Print(string str, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
        }
    }
}

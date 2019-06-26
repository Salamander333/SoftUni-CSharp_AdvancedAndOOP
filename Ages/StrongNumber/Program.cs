using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int temp = input;

            int i, f, r, sum = 0;

            while (input != 0)
            {
                i = 1; f = 1;

                r = input % 10;
                while (i <= r)
                {
                    f = f * i;
                    i++;
                }
                sum = sum + f;
                input = input / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

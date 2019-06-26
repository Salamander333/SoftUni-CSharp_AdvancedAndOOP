using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                int placeholder;
                placeholder = n % 10;
                sum += placeholder;
                n = n / 10;
                placeholder = 0;
            }

            Console.WriteLine(sum);
        }
    }
}

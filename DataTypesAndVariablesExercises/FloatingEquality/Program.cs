using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double fisrtNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double diff;
            double eps = 0.000001;

            diff = fisrtNumber - secondNumber;
            diff = Math.Abs(diff);
            if (diff >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}

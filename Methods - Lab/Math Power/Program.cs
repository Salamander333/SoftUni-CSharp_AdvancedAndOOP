using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = CalculatePower(number, power);

            Console.WriteLine(result);
        }

        static double CalculatePower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}

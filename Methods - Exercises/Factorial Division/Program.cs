using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());

            firstInput = CalculateFactorial(firstInput);
            secondInput = CalculateFactorial(secondInput);

            Console.WriteLine($"{DivideFactorials(firstInput, secondInput):f2}");
        }

        static double CalculateFactorial(double number)
        {
            double result = number;
            for (double i = number - 1; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }

        static double DivideFactorials(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}

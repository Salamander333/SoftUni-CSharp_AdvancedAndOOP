using System;

namespace ExchangeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int tempValue = firstNumber;

            Console.WriteLine($"Before: \n a = {firstNumber} \n b = {secondNumber}");
            firstNumber = secondNumber;
            secondNumber = tempValue;
            Console.WriteLine($"After: \n a = {firstNumber} \n b = {secondNumber}");
        }
    }
}

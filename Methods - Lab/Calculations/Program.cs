using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(firstInput, secondInput);
                    break;
                case "multiply":
                    Multiply(firstInput, secondInput);
                    break;
                case "subtract":
                    Subtract(firstInput, secondInput);
                    break;
                case "divide":
                    Divide(firstInput, secondInput);
                    break;
            }
        }

        static void Add(int numA, int numB)
        {
            Console.WriteLine(numA + numB);
        }
        static void Multiply(int numA, int numB)
        {
            Console.WriteLine(numA * numB);
        }
        static void Subtract(int numA, int numB)
        {
            Console.WriteLine(numA - numB);
        }
        static void Divide(int numA, int numB)
        {
            Console.WriteLine(numA / numB);
        }

    }
}

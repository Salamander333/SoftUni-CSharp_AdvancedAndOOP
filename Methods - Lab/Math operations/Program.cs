using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstN = double.Parse(Console.ReadLine());
            string _operator = Console.ReadLine();
            double secondN = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstN, _operator, secondN));
        }

        public static double Calculate (double firstNum, string _operator, double secondNum)
        {
            double result = 0;

            switch (_operator)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;

            }

            return Math.Round(result, 2);
        }
    }
}

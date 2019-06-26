using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart(new char[] {'0'});
            int secondNum = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            int addition = 0;

            if (firstNum == "0" || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int n = (int)Char.GetNumericValue(firstNum[i]);
                n = n * secondNum + addition;
                addition = n / 10;
                n = n % 10;
                result.Insert(0, n);
            }

            if (addition != 0)
            {
                result.Insert(0, addition);
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static string evens = string.Empty;
        static string odds = string.Empty;

        static int evensSum = 0;
        static int oddsSum = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            string input = n.ToString();
            var charArray = input.ToCharArray();

            foreach (char num in charArray)
            {
                GetMultipleOfEvenAndOdds(num);
            }

            evensSum = GetSum(evens);
            oddsSum = GetSum(odds);
            Console.WriteLine(evensSum * oddsSum);
        }

        public static void GetMultipleOfEvenAndOdds(char num)
        {
            if (num % 2 == 0)
            {
                evens += (" " + num);
            }
            else
            {
                odds += (" " + num);
            }
        }
        public static int GetSum(string numbers)
        {
            var temp = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int result = 0;
            foreach (int num in temp)
            {
                result += num;
            }
            return result;
        }
    }
}

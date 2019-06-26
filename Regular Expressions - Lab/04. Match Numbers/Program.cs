using System;
using System.Text.RegularExpressions;

namespace _04._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            var numbers = Regex.Matches(input, regex);

            foreach (Match match in numbers)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}

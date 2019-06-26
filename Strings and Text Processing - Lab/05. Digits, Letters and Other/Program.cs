using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> symbols = new List<char>();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits.Add(c);
                }
                else if (char.IsLetter(c))
                {
                    letters.Add(c);
                }
                else
                {
                    symbols.Add(c);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", symbols));
        }
    }
}

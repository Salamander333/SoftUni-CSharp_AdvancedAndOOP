using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            List<char> charList = new List<char>();

            foreach (char c in input)
            {
                if (charList.Count == 0)
                {
                    charList.Add(c);
                }

                var lastElement = charList.Last();
                if (lastElement != c)
                {
                    charList.Add(c);
                }
            }

            Console.WriteLine(string.Join("", charList));
        }
    }
}

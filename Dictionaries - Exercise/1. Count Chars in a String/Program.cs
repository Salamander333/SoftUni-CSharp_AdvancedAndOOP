using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            var charCount = new Dictionary<char, int>();

            foreach (string word in words)
            {
                foreach (char x in word)
                {
                    if (!charCount.ContainsKey(x))
                    {
                        charCount.Add(x, 0);
                    }
                    charCount[x]++;
                }
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

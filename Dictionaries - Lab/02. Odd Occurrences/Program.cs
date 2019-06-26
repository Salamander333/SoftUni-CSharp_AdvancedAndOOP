using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var words = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string wordInLower = word.ToLower();

                if (!words.ContainsKey(wordInLower))
                {
                    words.Add(wordInLower, 0);
                }

                words[wordInLower]++;
            }

            foreach (var count in words)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}

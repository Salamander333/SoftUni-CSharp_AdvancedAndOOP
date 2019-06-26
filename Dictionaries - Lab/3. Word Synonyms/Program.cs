using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < inputLines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonym);
            }
            foreach (var line in words)
            {
                Console.WriteLine($"{line.Key} - {string.Join(", ", line.Value)}");
            }
        }
    }
}

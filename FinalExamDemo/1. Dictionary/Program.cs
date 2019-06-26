using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var WordsDictionary = new SortedDictionary<string, List<string>>();

            string[] wordsAndDefinitions = Console.ReadLine().Split(" | ");
            foreach (var item in wordsAndDefinitions)
            {
                string[] input = item.Split(": ");
                string word = input[0];
                string definition = input[1];

                if (!WordsDictionary.ContainsKey(word))
                {
                    WordsDictionary.Add(word, new List<string>());
                }

                WordsDictionary[word].Add(definition);
            }


            string[] wordsToList = Console.ReadLine().Split(" | ");

            string endCommand = Console.ReadLine();
            if (endCommand == "List")
            {
                List(WordsDictionary);
                return;
            }
            else if (endCommand == "End")
            {
                End(wordsToList, WordsDictionary);
                return;
            }
        }

        static void List(SortedDictionary<string, List<string>> dictionary)
        {
            var words = new List<string>();

            foreach (var word in dictionary)
            {
                words.Add(word.Key);
            }

            Console.WriteLine(string.Join(" ", words));
        }

        static void End(string[] wordsToList, SortedDictionary<string, List<string>> dictionary)
        {
            foreach (var word in wordsToList)
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine(word);
                    var definitions = dictionary[word];
                    definitions = definitions.OrderByDescending(x => x.Length).ToList();
                    foreach (var definition in definitions)
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }
        }
    }
}

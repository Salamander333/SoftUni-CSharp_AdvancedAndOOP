using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string input = Console.ReadLine();

            while (input.Contains(wordToRemove))
            {
                var index = input.IndexOf(wordToRemove);
                
                input = input.Remove(index, wordToRemove.Length);
            }

            Console.WriteLine(input);
        }
    }
}

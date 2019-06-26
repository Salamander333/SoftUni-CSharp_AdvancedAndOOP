using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowelCount(input));
        }

        public static int VowelCount (string input)
        {
            int result = 0;
            foreach (char letter in input)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    result++;
                }
            }
            return result;
        }
    }
}

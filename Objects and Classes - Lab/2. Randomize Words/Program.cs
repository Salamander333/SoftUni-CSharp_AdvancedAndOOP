using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                int randomNum = rnd.Next(0, input.Length);
                var tmp = input[i];
                input[i] = input[randomNum];
                input[randomNum] = tmp;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}

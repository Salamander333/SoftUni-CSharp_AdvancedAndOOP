using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            var wordStack = new Stack<char>(input);
            int count = wordStack.Count();

            for (int i = 0; i < count; i++)
            {
                Console.Write(wordStack.Pop());
            }
            Console.WriteLine();
        }
    }
}

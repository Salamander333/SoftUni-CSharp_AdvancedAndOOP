using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var s = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    s.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = s.Pop();
                    string sub = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(sub);
                }
            }
        }
    }
}

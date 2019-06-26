using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            var charStack = new Stack<char>();

            foreach (var c in input)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    charStack.Push(c);
                }
                else if ((c == ')' || c == ']' || c == '}') && (charStack.Any()))
                {
                    var bracketToMatch = charStack.Pop();
                    switch (c)
                    {
                        case ')':
                            if (bracketToMatch != '(')
                            {
                                answerNo();
                                return;
                            }
                            break;
                        case ']':
                            if (bracketToMatch != '[')
                            {
                                answerNo();
                                return;
                            }
                            break;
                        case '}':
                            if (bracketToMatch != '{')
                            {
                                answerNo();
                                return;
                            }
                            break;
                    }
                }
                else
                {
                    answerNo();
                    return;
                }
            }

            Console.WriteLine("YES");
        }

        static void answerNo()
        {
            Console.WriteLine("NO");
        }
    }
}

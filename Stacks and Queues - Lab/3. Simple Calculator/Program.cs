using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());

            int result = int.Parse(stack.Pop());
            int counter = 2;
            var expression = "";

            while (stack.Any())
            {
                if (counter % 2 == 0)
                {
                    expression = stack.Pop();
                }
                else
                {
                    int num = int.Parse(stack.Pop());
                    if (expression == "-")
                    {
                        result -= num;
                    }
                    else if (expression == "+")
                    {
                        result += num;
                    }
                }
                counter++;
            }

            Console.WriteLine(result);
        }
    }
}

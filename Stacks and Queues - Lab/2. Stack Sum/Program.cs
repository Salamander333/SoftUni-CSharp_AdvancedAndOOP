using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            var numStack = new Stack<int>(input);

            var command = Console.ReadLine().ToLower().Split();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int firstNum = int.Parse(command[1]);
                    int secondNum = int.Parse(command[2]);

                    numStack.Push(firstNum);
                    numStack.Push(secondNum);
                }
                else if (command[0] == "remove")
                {
                    if (numStack.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            numStack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower().Split();
            }

            while (numStack.Any())
            {
                var num = numStack.Pop();
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

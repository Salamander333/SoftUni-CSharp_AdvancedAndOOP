using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            var previousCommands = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < inputLines; i++)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        previousCommands.Push(text);
                        text += command[1];
                        break;

                    case "2":
                        previousCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(command[1]));
                        break;

                    case "3":
                        Console.WriteLine(text[int.Parse(command[1]) - 1]);
                        break;

                    case "4":
                        text = previousCommands.Pop();
                        break;
                }
            }
        }
    }
}

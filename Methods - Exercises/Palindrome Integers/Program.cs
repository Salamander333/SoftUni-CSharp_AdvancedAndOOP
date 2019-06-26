using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                string reversedInput = ReverseInputString(input);
                if (input == "END")
                {
                    break;
                }
                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            } while (input != "END");

        }

        static string ReverseInputString (string str)
        {
            char[] inputArray = str.ToCharArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }
    }
}

using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string thirdChar = Console.ReadLine();
            string result = "";

            result = firstChar + secondChar + thirdChar;
            Console.WriteLine(result);
        }
    }
}

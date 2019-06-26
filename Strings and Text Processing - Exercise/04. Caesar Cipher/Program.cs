using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Append(Convert.ToChar(c + 3));
            }

            Console.WriteLine(sb);
        }
    }
}

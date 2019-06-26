using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            List<string> result = new List<string>();

            foreach (var s in input)
            {
                if (s.Length >= 3 && s.Length <= 16)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(s[i]) && s[i] != '-' && s[i] != '_')
                        {
                            break;
                        }
                        if (char.IsLetterOrDigit(s[i]) && i == s.Length - 1)
                        {
                            result.Add(s);
                        }
                    }
                }
            }

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}

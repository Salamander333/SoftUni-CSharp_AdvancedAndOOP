using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lineToDecipher = Console.ReadLine().ToCharArray();
            string[] decipheredLine = new string[lineToDecipher.Length];

            string[] substrings = Console.ReadLine().Split();
            string substringToReplace = substrings[0];
            string substringToReplaceWith = substrings[1];

            string pattern = @"[d-z{}|#]";
            foreach (var item in lineToDecipher)
            {
                string s = item.ToString();
                if (!Regex.IsMatch(s, pattern))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }

            for (int i = 0; i < lineToDecipher.Length; i++)
            {
                int charValue = lineToDecipher[i];
                charValue -= 3;
                decipheredLine[i] = Char.ConvertFromUtf32(charValue);
            }

            string decipheredLineString = string.Join("", decipheredLine);
            string decipheredMessage = decipheredLineString.Replace(substringToReplace, substringToReplaceWith);

            Console.WriteLine(decipheredMessage);
        }
    }
}

using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startInput = char.Parse(Console.ReadLine());
            char endInput = char.Parse(Console.ReadLine());

            string result = PrintCharacters((int)(startInput), (int)(endInput));

            Console.WriteLine(result);
        }

        static string PrintCharacters(int start, int end)
        {
            string result = string.Empty;

            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    result = result + Char.ConvertFromUtf32(i) + " ";
                }
            }
            else if (start > end)
            {
                for (int i = end + 1; i < start; i++)
                {
                    result = result + Char.ConvertFromUtf32(i) + " ";
                }
            }

            return result;
        }
    }
}

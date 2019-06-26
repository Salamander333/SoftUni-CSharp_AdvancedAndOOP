using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                bool isInt = int.TryParse(input, out int integer);
                bool isFloat = double.TryParse(input, out double floating);
                bool isChar = char.TryParse(input, out char character);
                bool isBool = bool.TryParse(input, out bool boolean);

                if (isInt)
                {
                    Console.WriteLine($"{integer} is integer type");
                }
                else if (isFloat)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{character} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}

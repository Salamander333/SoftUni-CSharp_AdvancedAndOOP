using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTopNumbers(input);
        }

        static void PrintTopNumbers (int input)
        {
            for (int i = 0; i <= input; i++)
            {
                char[] digits = i.ToString().ToCharArray();
                int sum = 0;
                foreach (int _int in digits)
                {
                    sum += _int;
                }
                if (sum % 8 == 0)
                {
                    bool printable = ContainsOddDigit(i);
                    if (printable)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static bool ContainsOddDigit (int number)
        {
            char[] digits = number.ToString().ToCharArray();

            foreach (int _int in digits)
            {
                if (_int % 2 != 0)
                {
                    return true;
                }
            }
            return false;    
        }
    }
}

using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool longEnough = checkPassLenght(input);
            bool enoughDigits = checkPassDigitCount(input);
            bool noSymbols = checkPassForSymbols(input);

            if (!longEnough)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!noSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!enoughDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (longEnough && enoughDigits && noSymbols)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool checkPassLenght (string pass)
        {
            int charCount = 0;
            foreach (char c in pass)
            {
                charCount++;
            }
            if (charCount >= 6 && charCount <= 10)
            {
                return true;
            }
            return false;
        }

        static bool checkPassDigitCount (string pass)
        {
            int digitCount = 0;
            foreach (char c in pass)
            {
                if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                if (digitCount >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        static bool checkPassForSymbols (string pass)
        {
            foreach (char c in pass)
            {
                if (!Char.IsLetter(c) && !Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

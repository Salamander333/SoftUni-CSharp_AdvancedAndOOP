using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 2; i <= input; i++)
            {
                bool isItPrime = true;
                for (n = 2; n < i; n++)
                {
                    if (i % n == 0)
                    {
                        isItPrime = false;
                    }
                }
                Console.WriteLine($"{n} -> {isItPrime.ToString().ToLower()}");
            }
        }
    }
}

using System;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputsCount = long.Parse(Console.ReadLine());

            for (long i = 0; i < inputsCount; i++)
            {
                var input = Console.ReadLine();
                var firstNum = input.Split(' ')[0];
                var secondNum = input.Split(' ')[1];
                long n1 = long.Parse(firstNum);
                long n2 = long.Parse(secondNum);


                long sum = 0;

                if (n1 > n2)
                {
                    n1 = Math.Abs(n1);
                    while (n1 != 0)
                    {
                        sum += n1 % 10;
                        n1 /= 10;
                    }
                }
                else if (n2 > n1)
                {
                    n2 = Math.Abs(n2);
                    while (n2 != 0)
                    {
                        sum += n2 % 10;
                        n2 /= 10;
                    }
                }
                else if (n2 == n1 || n1 == n2)
                {
                    n2 = Math.Abs(n2);
                    while (n2 != 0)
                    {
                        sum += n2 % 10;
                        n2 /= 10;
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}

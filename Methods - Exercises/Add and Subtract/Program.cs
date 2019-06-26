using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());

            Console.WriteLine(Substart ( Sum(firstN, secondN), thirdN ));
        }

        static int Sum (int a, int b)
        {
            return a + b;
        }

        static int Substart (int a, int b)
        {
            return a - b;
        }
    }
}

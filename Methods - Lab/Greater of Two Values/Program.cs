using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "int":
                    int firstN = int.Parse(Console.ReadLine());
                    int secondN = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstN, secondN));
                    break;
                case "char":
                    char firstC = char.Parse(Console.ReadLine());
                    char secondC = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstC, secondC));
                    break;
                case "string":
                    string firstS = Console.ReadLine();
                    string secondS = Console.ReadLine();
                    Console.WriteLine(GetMax(firstS, secondS));
                    break;
            }

        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            int compare = first.CompareTo(second);

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}

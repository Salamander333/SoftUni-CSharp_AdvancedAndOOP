using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int sum = GetCharSum(input[0], input[1]);

            Console.WriteLine(sum);
        }

        static int GetCharSum(string firstString, string secondString)
        {
            string shorterString = "";
            string longerString = "";

            int sum = 0;

            if (firstString.Length > secondString.Length)
            {
                shorterString = secondString;
                longerString = firstString;
            }
            else
            {
                shorterString = firstString;
                longerString = secondString;
            }

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += firstString[i] * secondString[i];
                if (i == shorterString.Length - 1)
                {
                    for (int j = i + 1; j < longerString.Length; j++)
                    {
                        sum += longerString[j];
                    }
                }
            }

            return sum;
        }
    }
}

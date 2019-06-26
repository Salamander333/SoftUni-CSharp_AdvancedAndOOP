using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input_1 = Console.ReadLine().Split();
            string[] input_2 = Console.ReadLine().Split();

            foreach (string str_2 in input_2)
            {
                for (int i = 0; i < input_1.Length; i++)
                {
                    if (str_2 == input_1[i])
                    {
                        Console.Write(str_2 + " ");
                    }
                }
            }
        }
    }
}

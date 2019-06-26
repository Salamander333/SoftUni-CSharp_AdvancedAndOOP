using System;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            int remainingPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(">");
                    int power = int.Parse(char.ConvertFromUtf32(input[i + 1]));
                    power += remainingPower;
                    remainingPower = 0;

                    for (int j = i + 1; j < i + 1 + power; j++)
                    {
                        if (j > input.Length - 1)
                        {
                            Console.WriteLine(sb);
                            return;
                        }
                        if (input[j] != '>')
                        {
                            i++;
                            power--;
                        }
                        else
                        {
                            remainingPower = power;
                            break;
                        }
                    }
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}

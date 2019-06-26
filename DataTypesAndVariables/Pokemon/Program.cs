using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            double originalPokePowerHalfed = pokePower * 0.50;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokeCount = 0;

            while (pokePower >= distance)
            {
                if (pokePower == originalPokePowerHalfed)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
                if (pokePower >= distance)
                {
                    pokePower -= distance;
                    pokeCount++;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}

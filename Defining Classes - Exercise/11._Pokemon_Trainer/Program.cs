using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Tournament")
                {
                    break;
                }

                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    var trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    var trainer = trainers.Find(x => x.Name == trainerName);
                    trainer.Pokemons.Add(pokemon);
                }
            }

            while (true)
            {
                var element = Console.ReadLine();
                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }

            trainers = trainers.OrderByDescending(x => x.Badges).ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}

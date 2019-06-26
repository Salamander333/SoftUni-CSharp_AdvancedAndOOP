using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var gems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            gems.Insert(0, 0);
            gems.Add(0);

            var commands = new List<string>();
            Predicate<int> predicate;

            while (true)
            {
                var command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Forge")
                {
                    break;
                }

                string secondaryCommand = $"{command[1]};{command[2]}";

                if (command[0] == "Reverse")
                {
                    commands.Remove(secondaryCommand);
                }
                else
                {
                    commands.Add(secondaryCommand);
                }

            }

            for (int _command = commands.Count - 1; _command >= 0; _command--)
            {
                var command = commands[_command].Split(";");
                var action = command[0];
                var count = int.Parse(command[1]);

                predicate = SetPredicate(gems, action, count);

                for (int gem = gems.Count - 2; gem > 0; gem--)
                {
                    if (predicate(gem))
                    {
                        gems.RemoveAt(gem);
                    }
                }
            }

            gems.RemoveAt(gems.Count - 1);
            gems.RemoveAt(0);

            Console.WriteLine(string.Join(" ", gems));
        }

        public static Predicate<int> SetPredicate(List<int> gems, string action, int count)
        {
            switch (action)
            {
                case "Sum Left":
                    return x => gems[x - 1] + gems[x] == count;

                case "Sum Right":
                    return x => gems[x] + gems[x + 1] == count;

                case "Sum Left Right":
                    return x => gems[x - 1] + gems[x] + gems[x + 1] == count;
            }

            return null;
        }
    }
}

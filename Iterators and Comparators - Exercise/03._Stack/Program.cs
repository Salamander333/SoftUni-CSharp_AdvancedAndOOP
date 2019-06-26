using System;
using System.Linq;

namespace _03._Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stacky = new Stacky<int>();

            while (true)
            {
                var command = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Push":
                        var items = command.Skip(1).Select(int.Parse).ToArray();
                        stacky.Push(items);
                        break;

                    case "Pop":
                        stacky.Pop();
                        break;

                    case "END":
                        for (int i = 0; i < 2; i++)
                        {
                            foreach (var item in stacky)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        return;
                }
            }
        }
    }
}

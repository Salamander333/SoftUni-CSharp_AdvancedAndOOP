using System;
using System.Linq;

namespace _01._ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var create = Console.ReadLine().Split().Skip(1).ToArray();

            var listy = new ListyIterator<string>(create);

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;

                    case "Print":
                        listy.Print();
                        break;

                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;

                    case "END":
                        return;
                }
            }
        }
    }
}

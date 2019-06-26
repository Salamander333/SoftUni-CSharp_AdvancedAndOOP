using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var pumpCount = int.Parse(Console.ReadLine());
            var pumpQueue = new Queue<Pump>();
            var pumpTestRun = new List<Pump>();

            for (int i = 0; i < pumpCount; i++)
            {
                int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumpQueue.Enqueue(new Pump(pump[0], pump[1], i));
            }

            var solution = false;
            Pump starterPump = null;

            while (solution == false)
            {
                starterPump = pumpQueue.Dequeue();
                pumpQueue.Enqueue(starterPump);
                pumpTestRun = pumpQueue.ToList();

                var currentPump = starterPump;

                int gasFueled = starterPump.GasFueled - starterPump.GasNeeded;

                if (gasFueled < 0)
                {
                    pumpTestRun = new List<Pump>(); ;
                    continue;
                }

                for (int i = 0; i < pumpCount; i++)
                {
                    if (gasFueled < 0)
                    {
                        pumpTestRun = new List<Pump>(); ;
                        break;
                    }

                    currentPump = pumpTestRun[i];
                    gasFueled += currentPump.GasFueled - currentPump.GasNeeded;
                    if (i == pumpCount -1)
                    {
                        solution = true;
                    }
                }
            }

            Console.WriteLine(starterPump.Index);
        }
    }

    class Pump
    {
        public int GasFueled { get; set; }
        public int GasNeeded { get; set; }
        public int Index { get; set; }

        public Pump(int gasFueled, int gasNeeded, int index)
        {
            GasFueled = gasFueled;
            GasNeeded = gasNeeded;
            Index = index;
        }
    }
}

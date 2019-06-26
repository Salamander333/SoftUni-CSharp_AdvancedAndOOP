using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] wagonArray = new int[wagonCount];
            int peopleSum = 0;

            for (int i = 0; i < wagonArray.Length; i++)
            {
                int currentWagonNumber = int.Parse(Console.ReadLine());
                wagonArray[i] = currentWagonNumber;
                peopleSum += wagonArray[i];
            }
            for (int i = 0; i < wagonArray.Length; i++)
            {
                Console.Write(wagonArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(peopleSum);
        }
    }
}

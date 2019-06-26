using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            float lostGames = float.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float token = 0;

            float brokenHeadset = 0;
            float brokenMouse = 0;
            float brokenKeyboard = 0;
            float brokenDisplay = 0;

            float expenses;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 )
                {
                    brokenHeadset++;
                }
                if (i % 3 == 0)
                {
                    brokenMouse++;
                }
                if (i % 6 == 0)
                {
                    brokenKeyboard++;
                    token++;
                    if (token % 2 == 0 && token != 0)
                    {
                        brokenDisplay++;
                    }
                }
            }
            expenses = (brokenHeadset * headsetPrice) + (brokenMouse * mousePrice) + (brokenKeyboard * keyboardPrice)
            + (brokenDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

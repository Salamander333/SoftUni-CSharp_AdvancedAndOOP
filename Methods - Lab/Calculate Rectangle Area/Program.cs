using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = CalculateRectangleArea(width, height);

            Console.WriteLine(area);
        }

        public static int CalculateRectangleArea(int w, int h)
        {
            return w * h;
        }
    }
}

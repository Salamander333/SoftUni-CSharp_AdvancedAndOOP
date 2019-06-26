using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Rectangle_Intersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numOfRectangles = n[0];
            var numOfChecks = n[1];

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < numOfRectangles; i++)
            {
                var rectangle = Console.ReadLine().Split();
                var rectangleId = rectangle[0];
                var rectangleW = double.Parse(rectangle[1]);
                var rectangleH = double.Parse(rectangle[2]);
                var rectangleCoordinatesH = double.Parse(rectangle[3]);
                var rectangleCoordinatesV = double.Parse(rectangle[4]);

                var r = new Rectangle(rectangleId, rectangleW, rectangleH, rectangleCoordinatesH, rectangleCoordinatesV);
                rectangles.Add(r);
            }

            for (int i = 0; i < numOfChecks; i++)
            {
                var recsToCheck = Console.ReadLine().Split();
                var rec_1 = rectangles.Find(x => x.Id == recsToCheck[0]);
                var rec_2 = rectangles.Find(x => x.Id == recsToCheck[1]);

                if (Rectangle.IsInteracting(rec_1, rec_2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

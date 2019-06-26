using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftCorner_horizontal;
        private double topLeftCorner_vertical;

        public string Id
        {
            get { return this.id; }
        }

        public Rectangle(string id, double width, double height, double topLeftCorner_horizontal, double topLeftCorner_vertical)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeftCorner_horizontal = topLeftCorner_horizontal;
            this.topLeftCorner_vertical = topLeftCorner_vertical;
        }

        public static bool IsInteracting(Rectangle rectangle_1, Rectangle rectangle_2)
        {
            if (rectangle_1.topLeftCorner_horizontal <= rectangle_2.topLeftCorner_horizontal + rectangle_2.width &&
                rectangle_1.topLeftCorner_horizontal + rectangle_1.width >= rectangle_2.topLeftCorner_horizontal &&
                rectangle_1.topLeftCorner_vertical >= rectangle_2.topLeftCorner_vertical - rectangle_2.height &&
                rectangle_1.topLeftCorner_vertical - rectangle_1.height <= rectangle_2.topLeftCorner_vertical)
            {
                return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Class_Box
{
    class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }

        public string GetSurfaceArea()
        {
            double result = 2 * ((lenght * width) + (lenght * height) + (width * height));
            return $"Surface Area - {result:f2}";
        }

        public string GetLateralSurfaceArea()
        {
            double result = 2 * ((lenght * height) + (width * height));
            return $"Lateral Surface Area - {result:f2}";
        }

        public string GetVolume()
        {
            double result = lenght * width * height;
            return $"Volume - {result:f2}";
        }
    }
}

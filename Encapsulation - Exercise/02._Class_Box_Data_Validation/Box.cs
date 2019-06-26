using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Class_Box_Data_Validation
{
    class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get => this.lenght;

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    Environment.Exit(0);
                }

                this.lenght = value;
            }
        }

        public double Width
        {
            get => this.width;

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(0);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(0);
                }

                this.height = value;
            }
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

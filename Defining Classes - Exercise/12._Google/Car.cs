﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _12._Google
{
    class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
    }
}

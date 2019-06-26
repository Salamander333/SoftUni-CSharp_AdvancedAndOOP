﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) { }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}

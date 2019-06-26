using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Birthday_Celebrations
{
    class Pet : IBorn
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}

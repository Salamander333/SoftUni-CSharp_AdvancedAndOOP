using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Birthday_Celebrations
{
    class Citizen : IIdentifiable, IBorn
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;
            set
            {
                var name = value;

                if (!char.IsUpper(name[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if (name.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstName = name;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                var name = value;

                if (!char.IsUpper(name[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (name.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");
                }

                this.lastName = name;
            }
        }


    }
}

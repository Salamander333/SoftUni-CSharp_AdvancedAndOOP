using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    class Doctor
    {
        public Doctor(string fName, string sName)
        {
            FirstName = fName;
            SecondName = sName;
            Patients = new List<string>();
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public List<string> Patients { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.SecondName;
            }
        }
    }
}

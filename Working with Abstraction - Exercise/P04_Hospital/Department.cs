using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    class Department
    {
        public Department(string name)
        {
            DepartmentName = name;
            Rooms = new List<List<string>>();
            for (int i = 0; i < 20; i++)
            {
                Rooms.Add(new List<string>());
            }
        }

        public string DepartmentName { get; set; }

        public List<List<string>> Rooms { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            var doctors = new List<Doctor>();
            var departments = new List<Department>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] tokens = command.Split();
                var department = tokens[0];
                var doctorFirstName = tokens[1];
                var doctorSecondName = tokens[2];
                var doctorFullName = doctorFirstName + " " + doctorSecondName;
                var patient = tokens[3];

                if (!doctors.Any(x => x.FullName == doctorFullName))
                {
                    doctors.Add(new Doctor(doctorFirstName, doctorSecondName));
                }

                if (!departments.Any(x => x.DepartmentName == department))
                {
                    departments.Add(new Department(department));
                }

                bool hasSpace = departments.Find(x => x.DepartmentName == department).Rooms.SelectMany(x => x).Count() < 60;
                if (hasSpace)
                {
                    var currentDepartment = departments.Find(x => x.DepartmentName == department);

                    int room = 0;
                    doctors.Find(x => x.FullName == doctorFullName).Patients.Add(patient);

                    for (int st = 0; st < currentDepartment.Rooms.Count; st++)
                    {
                        if (currentDepartment.Rooms[st].Count < 3)
                        {
                            room = st;
                            break;
                        }
                    }
                    currentDepartment.Rooms[room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments.Find(x => x.DepartmentName == args[0])
                        .Rooms
                        .Where(x => x.Count > 0)
                        .SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departments.Find(x => x.DepartmentName == args[0])
                        .Rooms[room - 1]
                        .OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors.Find(x => x.FullName == args[0] + " " + args[1])
                        .Patients
                        .OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}

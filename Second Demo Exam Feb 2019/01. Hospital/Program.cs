using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var hospital = new Dictionary<string, string[][]>();
            var _patients = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Output")
                {
                    break;
                }

                var department = input[0];
                if (!hospital.ContainsKey(department))
                {
                    hospital.Add(department, new string[20][]);
                    for (int i = 0; i < 20; i++)
                    {
                        hospital[department][i] = new string[3];
                    }
                }

                var doctor = input[1] + " " + input[2];
                var patient = input[3];
                _patients.Add(patient, doctor);
                for (int i = 0; i < 20; i++)
                {
                    var bedFound = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if (hospital[department][i][j] == null)
                        {
                            hospital[department][i][j] = patient;
                            bedFound = true;
                        }
                        if (bedFound)
                        {
                            break;
                        }
                    }
                    if (bedFound)
                    {
                        break;
                    }
                }

            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                if (input.Length == 1)
                {
                    var departmentToPrint = input[0];
                    foreach (var room in hospital[departmentToPrint])
                    {
                        foreach (var patient in room)
                        {
                            if (patient != null)
                            {
                                Console.WriteLine(patient);
                            }
                        }
                    }
                }
                else
                {
                    int room = -1;
                    if (int.TryParse(input[1], out room))
                    {
                        room -= 1;
                        var departmentToPrint = input[0];
                        var listOfPatientsToPrint = hospital[departmentToPrint][room].OrderBy(x => x);
                        foreach (var patient in listOfPatientsToPrint)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        var doctorToPrint = input[0] + " " + input[1];
                        var listOfPatientsToPrint = _patients.Where(x => x.Value == doctorToPrint).OrderBy(x => x.Key);
                        foreach (var patient in listOfPatientsToPrint)
                        {
                            Console.WriteLine(patient.Key);
                        }
                    }
                }
            }
        }
    }
}

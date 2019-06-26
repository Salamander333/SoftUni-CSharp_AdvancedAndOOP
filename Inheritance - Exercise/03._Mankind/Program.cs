using System;

namespace _03._Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentArgs = Console.ReadLine().Split();
                var studentFirstName = studentArgs[0];
                var studentLastName = studentArgs[1];
                var studenFacultyNumber = studentArgs[2];

                var workerArgs = Console.ReadLine().Split();
                var workerFirstName = workerArgs[0];
                var workerLastName = workerArgs[1];
                var workerWeekSalary = decimal.Parse(workerArgs[2]);
                var workerWeekWorkingHours = int.Parse(workerArgs[3]);

                var student = new Student(studentFirstName, studentLastName, studenFacultyNumber);
                var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWeekWorkingHours);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}

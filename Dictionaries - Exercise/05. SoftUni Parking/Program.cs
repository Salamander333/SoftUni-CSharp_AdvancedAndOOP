using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            var registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                if (inputLine[0] == "register")
                {
                    string username = inputLine[1];
                    string plateNumber = inputLine[2];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        registeredUsers.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if(inputLine[0] == "unregister")
                {
                    string username = inputLine[1];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in registeredUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}

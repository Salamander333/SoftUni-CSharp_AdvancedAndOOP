using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] usernameArray = username.ToCharArray();
            Array.Reverse(usernameArray);
            string reversed = string.Empty;
            foreach (char ch in usernameArray)
            {
                reversed += ch;
            }
            string password = Console.ReadLine();
            

            bool tryWhile = true;
            int count = 0;

            while (tryWhile)
            {
                if (count < 3)
                {
                    if (password != reversed)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        password = Console.ReadLine();
                        count++;

                    }
                    else if (password == reversed)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        tryWhile = false;
                    }
                }
                if (count == 3)
                {
                    if (password != reversed)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        tryWhile = false;
                    }
                    else if (password == reversed)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        tryWhile = false;
                    }
                }
            }
        }
    }
}

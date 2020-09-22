using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = String.Empty;
            int counter = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];  
            }

            while (true)
            {
                string currentUser = Console.ReadLine();
                if (currentUser !=password)
                {
                    counter++;
                   
                    if (counter>=4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                
            }
            
        }
    }
}

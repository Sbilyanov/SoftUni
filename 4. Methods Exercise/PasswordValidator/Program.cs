using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordIsValid = ValidatePasswordLength(password) &&
                                   ValidatePasswordIsLetterOrDigits(password) &&
                                   ValidatePasswordIsTwoDigits(password);
            if (passwordIsValid)
            {
                Console.WriteLine("Password is valid");
            }
            if (!passwordIsValid)
            {
                if (!ValidatePasswordLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidatePasswordIsLetterOrDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!ValidatePasswordIsTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }
        }

        private static bool ValidatePasswordIsTwoDigits(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }          
                return false;
        }

        private static bool ValidatePasswordIsLetterOrDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}

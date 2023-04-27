using System;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of password :: ");

            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Password :: ");

            string password = Console.ReadLine();

            PasswordValidator validator = new PasswordValidator(password, length);

            validator._Password = password;



            if (validator.isValid)
            {
                Console.WriteLine("Password Generated ....");
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Try Again");
            }
            


        }
    }
}

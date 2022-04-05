using System;
using UserRegistrationMSTesting;

namespace UserRegistrationTesting
{
    class program
    {
        public static void Main(string[] args)
        {
            Validation userRegistration = new Validation();
            int options = 0;
            do
            {
                Console.WriteLine("Choose 1: First name ");

                try
                {
                    options = int.Parse(Console.ReadLine());
                    switch (options)
                    {
                        case 1:
                            Console.WriteLine("Enter your First Name: ");
                            string input = Console.ReadLine();
                            userRegistration.ValidFirstName(input);
                            break;
                        default:
                            Console.WriteLine("Choose From the Options given above");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a valid option");
                }
            } while (options != 0);
        }
    }
}

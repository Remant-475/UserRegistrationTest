using System;
using UserRegistrationMSTesting;

namespace UserRegistrationTesting
{
    class program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            int options = 0;
            do
            {
                Console.WriteLine("Choose 1: First name ");
                Console.WriteLine("Choose 2: Last name ");
                Console.WriteLine("Choose 3: Email ");
                Console.WriteLine("Choose 4: Phone Number ");
                Console.WriteLine("Choose 5: Pasword min 8 character ");
                Console.WriteLine("Choose 6: Pasword Atleast one uppercase ");
                Console.WriteLine("Choose 6: Pasword  one Numeric ");
                Console.WriteLine("Choose 6: Pasword atleast one special char ");
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
                        case 2:
                            Console.WriteLine("Enter your Last Name: ");
                            input = Console.ReadLine();
                            userRegistration.ValidLastName(input);
                            break;
                        case 3:
                            Console.WriteLine("Enter your Email: ");
                            input = Console.ReadLine();
                            userRegistration.ValidEmail(input);
                            break;
                        case 4:
                            Console.WriteLine("Enter your Mobile Number: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPhoneNumber(input);
                            break;
                        case 5:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRule_1(input);
                            break;
                        case 6:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRule_2(input);
                            break;
                        case 7:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRule_3(input);
                            break;
                        case 8:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRule_4(input);
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

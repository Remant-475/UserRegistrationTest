using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTesting
{
    public class UserRegistration
    {

        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailRegex = new Regex("^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex PhoneRegex = new Regex(@"^[]0-9]{2}\s[0-9]{10}$");
        public void ValidFirstName(string firstName)
        {
            Console.WriteLine("First name - " + firstName);
            if (FirstNameRegex.IsMatch(firstName))
                Console.WriteLine($"{firstName} is valid");
            else
                Console.WriteLine($"{firstName} is Invalid");

        }
        public void ValidLastName(string lastName)
        {
            Console.WriteLine("Last name - " + lastName);
            if (LastNameRegex.IsMatch(lastName))
                Console.WriteLine($"{lastName} is valid");
            else
                Console.WriteLine($"{lastName} is Invalid");

        }
        public void ValidEmail(string email)
        {
            Console.WriteLine("Email - " + email);
            if (EmailRegex.IsMatch(email))
                Console.WriteLine($"{email} is valid");
            else
                Console.WriteLine($"{email} is Invalid");
        }
        public void ValidPhoneNumber(string phonenumber)
        {
            Console.WriteLine("PhoneNumber :" + phonenumber);
            if (PhoneRegex.IsMatch(phonenumber))
                Console.WriteLine("PhoneNumber is valid");
            else
                Console.WriteLine("PhoneNumber is invalid");
        }


    }
}
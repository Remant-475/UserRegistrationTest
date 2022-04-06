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
        public Regex PasswordRule_1 = new Regex(@"^[A-Z a-z]{8,}$");
        public Regex PasswordRule_2 = new Regex(@"^(?=.*[A-Z])[A-Z a-z]{8,}$");
        public Regex PasswordRule_3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Z a-z 0-9]{8,}$");
        public Regex PasswordRule_4 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9]{8,}$");
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
        public void ValidPasswordRule_1(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRule_1.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRule_2(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRule_2.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRule_3(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRule_3.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRule_4(string password)
        {
            if (PasswordRule_4.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
    }
}
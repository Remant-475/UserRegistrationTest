using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTesting
{
    public class Validation
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailRegex = new Regex("^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex PhoneRegex = new Regex(@"^[]0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRule_1 = new Regex(@"^[A-Z a-z]{8,}$");
        public Regex PasswordRule_2 = new Regex(@"^(?=.*[A-Z])[A-Z a-z]{8,}$");
        public Regex PasswordRule_3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Z a-z 0-9]{8,}$");
        public Regex PasswordRule_4 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9]{8,}$");
        public string ValidFirstName(string firstName)
        {
            bool result = false;
            if (FirstNameRegex.IsMatch(firstName)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Empty,
                            "First name should not be empty");
                    else if (firstName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Less_Than_Three,
                            "First name should contain atleast three character");
                }
                else
                {
                    return "First Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "First Name is Invalid";
        }
        public string ValidLastName(string lastName)
        {
            bool result = false;
            if (LastNameRegex.IsMatch(lastName)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (lastName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Empty,
                            "Last name should not be empty");
                    else if (lastName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Less_Than_Three,
                            "Last name should contain atleast three character");

                    else if (!char.IsUpper(lastName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Start_With_Upper_Case,
                            "Last name should start with upper case");

                }
                else
                {
                    return "Last Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Last Name is Invalid";
        }
        public string ValidEmail(string email)
        {
            bool result = false;
            if (EmailRegex.IsMatch(email)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (email.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Empty,
                            "Email should not be empty");
                    else if (email.Length < 7)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_With_Min_Char,
                            "Email should contain atleast seven character");
                    else if (!email.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Contains_SpecialChar,
                            "Email should contain special characters");
                    else if (!email.Contains('@'))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Contain_Symbol,
                            "Email should contains @ Symbol");
                }
                else return "Email is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Email is Invalid";
        }
        public string ValidPhoneNumber(string phoneNumber)
        {
            bool result = false;
            if (PhoneRegex.IsMatch(phoneNumber)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (phoneNumber.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Mobile_Number_Empty,
                            "Phone number should not be empty");
                    else if (phoneNumber.Length < 10)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Mobile_Atleast_TenDigit,
                            "Phone number should contain atleast ten digits");
                }
                else return "Phone Number is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Phone number is Invalid";
        }
        public string ValidPasswordMinEightChar(string password)
        {
            bool result = false;
            if (PasswordRule_1.IsMatch(password)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_Empty,
                            "Password should not be empty");
                    else if (password.Length < 8)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_Min_Eight_Char,
                            "Password should contain atleast eight characters");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordAtleastOneUpperCase(string password)
        {
            bool Password(string Password) => PasswordRule_2.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_Empty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_AtLeast_OneUpperCase,
                            "Password should contain atleast one upper case character");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordAtLeastOneNumeric(string password)
        {
            bool Password(string Password) => PasswordRule_3.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_Empty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_AtLeast_OneNumeric,
                            "Password should contain atleast one Digit");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordAtLeastOneSpecialChar(string password)
        {
            bool Password(string Password) => PasswordRule_4.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_Empty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Password_OneSpecial_Char,
                            "Password should contain atleast one special character");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
    }
}


    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTesting
{

    public class UserValidationCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Name_Empty,
            Name_Less_Than_Three,
            Name_Start_With_Upper_Case,
            Email_Empty,
            Email_With_Min_Char,
            Email_Contains_SpecialChar,
            Email_Contain_Symbol,
            Mobile_Number_Empty,
            Mobile_Atleast_TenDigit,
            Password_Empty,
            Password_Min_Eight_Char,
            Password_AtLeast_OneUpperCase,
            Password_AtLeast_OneNumeric,
            Password_OneSpecial_Char,
        }
        public UserValidationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
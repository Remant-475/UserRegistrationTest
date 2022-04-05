﻿using System;
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
        }
        public UserValidationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
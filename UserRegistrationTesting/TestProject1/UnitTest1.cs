using NUnit.Framework;
using System;
using UserRegistrationTesting;


namespace UserRegistrationTesting
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void ValidFirstName()
        {
            string expected = "First Name is Valid";
            string name = "Remant";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidLastName()
        {
            string expected = "Last Name is Valid";
            string name = "Mahato";
            string result = validation.ValidLastName(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidEmail()
        {
            string expected = "Email is Valid";
            string result = null;
            string email = "remo-145@gmail.com";
            try
            {
                result = validation.ValidEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPhone()
        {
            string expected = "Phone number is Valid";
            string result = null;
            try
            {
                string phone = "91 9798777067";
                result = validation.ValidPhoneNumber(phone);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        public void ValidPassWord()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "jellyfish";
                result = validation.ValidPasswordMinEightChar(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        public void ValidPassword_2()
        {
            string result = null;
            string expected = "Password shold contain atleast one upper case";
            try
            {
                string password = "Jellyfish";
                result = validation.ValidPasswordAtleastOneUpperCase(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord_3()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters,one Upper Case and one number";
            try
            {
                string password = "Jellyfish2";
                result = validation.ValidPasswordAtLeastOneNumeric(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord_4()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters,one Upper Case, one number and one special character";
            try
            {
                string password = "Jellyfish2#";
                result = validation.ValidPasswordAtLeastOneSpecialChar(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
    }
}
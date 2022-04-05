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
            string email = "bittanraghu@gmail.com";
            try
            {
                result = validation.ValidEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
    }
}
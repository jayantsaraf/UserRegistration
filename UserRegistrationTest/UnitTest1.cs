using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExPatterns;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Jayant")]

        public void GIVEN_FIRST_NAME_SHOULD_RETURN_FIRST_NAME(string fName)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> firstName = new List<string>() { fName };
            bool expected = true;

            ////Act
            bool actual = User.ValidateFirstName(firstName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Sam")]
        [DataRow("Saraf")]
        public void GIVEN_FIRST_NAME_SHOULD_RETURN_ERRORS(string fName)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> firstName = new List<string>() { fName };
            bool expected = false;

            ////Act
            bool actual = User.ValidateFirstName(firstName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Saraf")]
        public void GIVEN_Last_NAME_SHOULD_RETURN_LAST_NAME(string lName)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> lastName = new List<string>() { lName };
            bool expected = true;

            ////Act
            bool actual = User.ValidateLastName(lastName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Sharaf")]
        [DataRow("sharaf")]
        [DataRow("Sh1araf")]
        public void GIVEN_Last_NAME_SHOULD_RETURN_ERROR(string lName)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> lastName = new List<string>() { lName };
            bool expected = false;

            ////Act
            bool actual = User.ValidateLastName(lastName);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("shah1998@gmail.com")]
        [DataRow("jayant@gmail.co.in")]
        public void GIVEN_EMAIL_ID_SHOULD_RETURN_EMAIL_ID(string email)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> emailAddress = new List<string>() { email };
            bool expected = true;

            ////Act
            bool actual = User.ValidateEmail(emailAddress);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("sarafjayant1998@gmail.co@@")]
        [DataRow("SaWI..SHAH@gmail.com")]
        public void GIVEN_EMAIL_ID_SHOULD_RETURN_ERROR(string email)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> emailAddress = new List<string>() { email };
            bool expected = false;

            ////Act
            bool actual = User.ValidateEmail(emailAddress);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("919163572895")]
        [DataRow("916263572895")]
        public void GIVEN_MOBILE_NUMBER_SHOULD_RETURN_MOBILE_NUMBER(string mobilenumber)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> phoneNumber = new List<string>() { mobilenumber };
            bool expected = true;

            ////Act
            bool actual = User.ValidatePhone(phoneNumber);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("9163572894")]
        [DataRow("12812458098")]
        [DataRow("916@572895")]


        public void GIVEN_MOBILE_NUMBER_SHOULD_RETURN_ERROR(string mobilenumber)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> phoneNumber = new List<string>() { mobilenumber };
            bool expected = false;

            ////Act
            bool actual = User.ValidatePhone(phoneNumber);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Tajmahal1!")]

        public void GIVEN_PASSWORD_SHOULD_RETURN_PASSWORD(string password)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> passWord = new List<string>() { password };
            bool expected = true;

            ////Act
            bool actual = User.ValidatePassword(passWord);

            ////Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataRow("Saraf")]
        [DataRow("Saraf1!")]

        public void GIVEN_PASSWORD_SHOULD_RETURN_ERROR(string password)
        {
            ////Arrange
            Patterns User = new Patterns();
            List<string> passWord = new List<string>() { password };
            bool expected = false;

            ////Act
            bool actual = User.ValidatePassword(passWord);

            ////Assert
            Assert.AreEqual(expected, actual);

        }

    }
}

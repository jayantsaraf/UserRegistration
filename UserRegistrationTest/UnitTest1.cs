using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExPatterns;
using System.Security.Cryptography.X509Certificates;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyTest()
        {
            string message = null;
            Patterns user = new Patterns();
            bool check1 = user.ValidateFirstName("Jayant");
            bool check2 = user.ValidateLastName("Saraf");
            bool check3 = user.ValidateEmail("sarafjayant24@gmail.com");
            bool check4 = user.ValidatePhone("918017126325");
            bool check5 = user.ValidatePassword("Saraf@24");
            if(check1==true && check2==true && check3 == true && check4 == true && check5 == true)
            {
                message = "Validation Successful";
            }
            Assert.AreEqual("Validation Successful", message);
        }
        [TestMethod]
        public void SadTest()
        {
            string message = null;
            Patterns user = new Patterns();
            bool check1 = user.ValidateFirstName("jayant");
            bool check2 = user.ValidateLastName("saraf");
            bool check3 = user.ValidateEmail("sarafjayant24gmail.com");
            bool check4 = user.ValidatePhone("8017126325");
            bool check5 = user.ValidatePassword("raf@24");
            if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                message = "Validation Successful";
            }
            else
            {
                message = "Validation Unsuccessful";
            }
            Assert.AreEqual("Validation Unsuccessful", message);
        }
        [TestMethod]
        public void MultipleMail()
        {
            string message = null;
            Patterns user = new Patterns();
            bool check1 = user.ValidateEmail("abc@yahoo.com");
            bool check2 = user.ValidateEmail("abc-100@yahoo.com");
            bool check3 = user.ValidateEmail("abc.100@yahoo.com");
            if (check1 == true && check2 == true && check3 == true)
            {
                message = "Email Validation Successful";
            }
            Assert.AreEqual("Email Validation Successful", message);
        }
    }
}

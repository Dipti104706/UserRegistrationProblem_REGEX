using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblem_REGEX;

namespace UserUnitTest
{
    [TestClass]
    public class MsTestforUserRegistration
    {
        UserRegistration obj = null;
        [TestMethod]
        [TestInitialize]
        //It is used in every test case of reflection, so initialize in the top
        public void SetUp()
        {
            obj = new UserRegistration();
        }

        //TC for validating multiple Email with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]

        public void MailValidation(string mail)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingEmailId(mail);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]

        public void InvalidEmail(string mail)
        {
            //AAA Methology
            //Arrange
            string expected = "Invalid";

            //ACT
            var actual = obj.ValidatingEmailId(mail);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}

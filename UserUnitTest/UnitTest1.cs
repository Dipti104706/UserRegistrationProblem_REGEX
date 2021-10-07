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

        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("Diptimayee")]

        //TC for validating first name with both valid and invalid case
        public void FirstNameValidation(string firstName)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingFirstName(firstName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("dip")]

        public void InvalidFirstName(string firstName)
        {
            //AAA Methology
            //Arrange
            string expected ="Invalid";

            //ACT
            var actual = obj.ValidatingFirstName(firstName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("Behura")]
        //TC for validating last name with both valid and invalid case
        public void LastNameValidation(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingLastName(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("d")]
        public void InvalidLastName(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "Invalid";

            //ACT
            var actual = obj.ValidatingLastName(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        //TC for validating Email with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("abc@yahoo.com")]

        public void MailValidation(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingEmailId(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("abc@.com.my")]
        public void InvalidEmail(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "Invalid";

            //ACT
            var actual = obj.ValidatingEmailId(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        //TC for validating phone numr with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("91 7055264706")]

        public void MobileNumValidation(string phNum)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingMobile(phNum);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("23c597")]
        public void InvalidMobileNumber(string phNum)
        {
            //AAA Methology
            //Arrange
            string expected = "Invalid";

            //ACT
            var actual = obj.ValidatingMobile(phNum);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        //TC for validating password with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("sdAc@f1ghj")]

        public void PasswordValidation(string psword)
        {
            //AAA Methology
            //Arrange
            string expected = "Valid";

            //ACT
            var actual = obj.ValidatingPassWord(psword);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sadgroup")]
        [DataRow("Aa1sd")]
        public void InvalidPassWord(string psword)
        {
            //AAA Methology
            //Arrange
            string expected = "Invalid";

            //ACT
            var actual = obj.ValidatingPassWord(psword);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}

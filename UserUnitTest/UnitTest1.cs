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
        //It is used in every test case, so initialize in the top
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
            string expected = "Diptimayee";

            //ACT
            var actual = obj.ValidatingFirstName(firstName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        //Tc for testing all invalid cases and through custom exception
        //
        [TestMethod]
        [TestCategory("Customexception")]
        [DataRow("di", "Invalid First Name")]

        public void InvalidFirstName(string firstName,string expected)
        {
            try
            {
                var actual = obj.ValidatingFirstName(firstName);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }

        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("Behura")]
        //TC for validating last name with both valid and invalid case
        public void LastNameValidation(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "Behura";

            //ACT
            var actual = obj.ValidatingLastName(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        //TC for validating last name with invalid case
        [TestMethod]
        [TestCategory("Customexception")]
        [DataRow("behura", "Invalid Last name")]

        public void InvalidLastName(string lastName, string expected)
        {
            try
            {
                var actual = obj.ValidatingFirstName(lastName);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }

        //TC for validating Email with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("abc@yahoo.com")]

        public void MailValidation(string lastName)
        {
            //AAA Methology
            //Arrange
            string expected = "abc@yahoo.com";

            //ACT
            var actual = obj.ValidatingEmailId(lastName);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        //TC for validating Email with invalid case
        [TestMethod]
        [TestCategory("Customexception")]
        [DataRow("abc@.com.my", "Invalid Email Id")]

        public void InvalidEmail(string email, string expected)
        {
            try
            {
                var actual = obj.ValidatingFirstName(email);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }

        //TC for validating phone numr with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("91 7055264706")]

        public void MobileNumValidation(string phNum)
        {
            //AAA Methology
            //Arrange
            string expected = "91 7055264706";

            //ACT
            var actual = obj.ValidatingMobile(phNum);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        //TC for validating phone numr with invalid case
        [TestMethod]
        [TestCategory("Customexception")]
        [DataRow("23c597", "Invalid Mobile number")]

        public void InvalidMobilenum(string mobileNum, string expected)
        {
            try
            {
                var actual = obj.ValidatingFirstName(mobileNum);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }

        //TC for validating password with both valid and invalid case
        [TestMethod]
        [TestCategory("Happygroup")]
        [DataRow("sdAc@f1ghj")]

        public void PasswordValidation(string psword)
        {
            //AAA Methology
            //Arrange
            string expected = "sdAc@f1ghj";

            //ACT
            var actual = obj.ValidatingPassWord(psword);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        //TC for validating password with invalid case
        [TestMethod]
        [TestCategory("Customexception")]
        [DataRow("23c597", "Invalid Password")]

        public void InvalidpassWord(string psword, string expected)
        {
            try
            {
                var actual = obj.ValidatingFirstName(psword);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.message);
            }
        }
    }
}

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

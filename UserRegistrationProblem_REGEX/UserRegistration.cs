using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem_REGEX
{/// <summary>
/// UC11 for validate emaildetails with parameterized mstest
/// </summary>
    public class UserRegistration
    {
        public string firstName;
        public string lastName;
        public string email;
        public string mobile;
        public string paasWord;

        //Method for validating first name given by user
        public string ValidatingFirstName(string firstName)
        {
            string pattern = "^[A-Z]+[a-z]{3,}$";
            Regex regex = new Regex(pattern);
            bool input = regex.IsMatch(firstName);
            try
            {
                if (input)
                {
                    Console.WriteLine(firstName + " ----->Valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(firstName + " ----->Invalid");
                    return "Invalid";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Method for validatinglast name given by user
        public string ValidatingLastName(string lastName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(pattern);
            bool input = regex.IsMatch(lastName);
            try
            {
                if (input)
                {
                    Console.WriteLine(lastName + " ----->Valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(lastName + " ----->Invalid");
                    return "Invalid";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ValidatingEmailId(string email)
        {
            string emailPattern = ("^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$");
            Regex regex = new Regex(emailPattern);
            bool input = regex.IsMatch(email);
            try
            {
                if (input)
                {
                    Console.WriteLine(email + " ----->Valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(email + " ----->Invalid");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ValidatingMobile(string mobile)
        {
            string phoneNumPattern = "^[0-9]{2}[  ]*[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            bool input = regex.IsMatch(mobile);
            try
            {
                if (input)
                {
                    Console.WriteLine(mobile + " ----->Valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(mobile + " ----->Invalid");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ValidatingPassWord(string paasWord)
        {
            string passwordPattern = "^[a-zA-Z0-9]{1,}[A-Z]*[0-9]*[@&#%$*_-]+[a-zA-Z0-9]*$";
            Regex regex = new Regex(passwordPattern);
            bool input = regex.IsMatch(paasWord);
            try
            {
                if (input)
                {
                    Console.WriteLine(paasWord + " ----->Valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(paasWord + " ----->Invalid");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

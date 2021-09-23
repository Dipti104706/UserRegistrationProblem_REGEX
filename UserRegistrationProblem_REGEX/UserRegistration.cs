using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_REGEX
{/// <summary>
/// UC9 creating regular expression for testing all email sample
/// </summary>
    class UserRegistration
    {
        //writing the valid pattern
        string email = "^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]+@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,10}[.]*[a-zA-Z]*$";
        string[] inputs = {"abc@yahoo.com","abc-100@yahoo.com", "abc.100@yahoo.com","abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com", "abc+100@gmail.com",
                            "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au" };
        /// <summary>
        /// Validation this instance.
        /// </summary>
        public void Validation()
        {
            Regex regex1 = new Regex(email);
            Console.WriteLine("Validating Email id: ");
            ItarateLoop(inputs, regex1);
        }
        public void ItarateLoop(string[] arr, Regex regex1)
        {
            for (int i = 0; i < arr.Length; i++)//validation Loop
            {
                bool result = regex1.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + ": is-->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + ": is-->" + "Invalid");
                }
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_REGEX
{/// <summary>
/// UC4 creating regular expression for validating phone number
/// </summary>
    class UserRegistration
    {
        //writing the valid pattern
        string password = "^[a-zA-z]{8,}$";
        string[] inputs = {"asdcfghj","asd","AASDEFFAgkkhkhu"};

        /// <summary>
        /// Validation this instance.
        /// </summary>
        public void Validation()
        {
            Regex regex1 = new Regex(password);
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

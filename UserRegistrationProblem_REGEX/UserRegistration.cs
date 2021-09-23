using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_REGEX
{/// <summary>
/// UC2 creating regular expression for validating user last name
/// </summary>
    class UserRegistration
    {
        //writing the valid pattern
        string pattern = "^[A-Z]{1}[a-z]{2,}$";
        string[] inputs = {"Behura", "DDhui","behura","Be"};//Validating some Example


        /// <summary>
        /// Validation this instance.
        /// </summary>
        public void Validation()
        {
            Regex regex1 = new Regex(pattern);
            Console.WriteLine("Validating Last name: ");
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

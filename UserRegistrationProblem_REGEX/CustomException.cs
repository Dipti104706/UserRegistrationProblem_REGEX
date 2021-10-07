using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_REGEX
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_EMAIL, INVALID_MOBILE, INVALID_PASSWORD
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

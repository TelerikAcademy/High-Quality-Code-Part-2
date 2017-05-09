using System;

namespace ProjectManager.Common.Exceptions
{
    public class UserValidationException : Exception
    {
        private const string ExceptionPrefix = " - Error: ";

        public UserValidationException(string message) 
            : base(ExceptionPrefix + message)
        {
        }
    }
}

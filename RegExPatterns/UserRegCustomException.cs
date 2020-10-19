using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegCustomException:Exception
    {
        public string message;
        public UserRegCustomException(string message)
        {
            this.message = message;
        }
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD = 12,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE,
            STRING_LENGTH_NOT_MATCHED
        }
        private readonly ExceptionType type;
        public UserRegCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}

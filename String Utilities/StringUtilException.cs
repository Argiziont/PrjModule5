using System;

namespace String_Utilities
{
    class StringUtilException : Exception
    {
        public StringUtilException() : this(null) { }
        public StringUtilException(string message) : base(message) { }
    }
}

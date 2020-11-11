using System;

namespace String_Utilities
{
    public class StringUtilException : Exception
    {
        public StringUtilException() : this(null) { }
        public StringUtilException(string message) : base(message) { }
    }
}

using System;

namespace Defender {
    /// <summary>
    /// The exception that is thrown when the two objects are equal.
    /// </summary>
    public class ArgumentEqualException : ArgumentException {
        public ArgumentEqualException() { }
        public ArgumentEqualException(String message) : base(message) { }
        public ArgumentEqualException(String message, Exception inner) : base(message, inner) { }
        public ArgumentEqualException(String paramName, String message) : base(message, paramName) { }
        public ArgumentEqualException(String paramName, String message, Exception inner) : base(message, paramName, inner) { }
    }
}

using System;

namespace Defender {
    /// <summary>
    /// The exception that is thrown when the two objects are not equal.
    /// </summary>
    public class ArgumentInequalException : ArgumentException {
        public ArgumentInequalException() { }
        public ArgumentInequalException(String message) : base(message) { }
        public ArgumentInequalException(String message, Exception inner) : base(message, inner) { }
        public ArgumentInequalException(String paramName, String message) : base(message, paramName) { }
        public ArgumentInequalException(String paramName, String message, Exception inner) : base(message, paramName, inner) { }
    }
}

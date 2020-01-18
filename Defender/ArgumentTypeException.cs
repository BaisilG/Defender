using System;

namespace Defender {
    /// <summary>
    /// The exception that is thrown when an object is passed to a method that expects a specific type, but is not of that type.
    /// </summary>
    public class ArgumentTypeException : ArgumentException {
        public ArgumentTypeException() { }
        public ArgumentTypeException(String message) : base(message) { }
        public ArgumentTypeException(String message, Exception inner) : base(message, inner) { }
        public ArgumentTypeException(String paramName, String message) : base(message, paramName) { }
        public ArgumentTypeException(String paramName, String message, Exception innerException) : base(message, paramName, innerException) { }
        public ArgumentTypeException(String paramName, Type paramType) : this(paramName, $"Argument not of type {paramType}.") { }
        public ArgumentTypeException(String paramName, Type paramType, String message) : this(paramName, $"Argument not of type {paramType}. {message}") { }
        public ArgumentTypeException(String paramName, Type paramType, Exception innerException) : this(paramName, $"Argument not of type {paramType}.", innerException) { }
        public ArgumentTypeException(String paramName, Type paramType, String message, Exception innerException) : this(paramName, $"Argument not of type {paramType}. {message}", innerException) { }
    }
}

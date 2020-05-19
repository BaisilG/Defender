using System;
#if !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Defender.Exceptions {
	/// <summary>
	/// The exception that is thrown when an object is passed to a method that expects a specific type, but is not of that type.
	/// </summary>
#if !NETSTANDARD1_0
	[Serializable]
#endif
	public sealed class ArgumentTypeException : ArgumentException {
		private ArgumentTypeException(String paramName, String message) : base(message, paramName) { }

		public ArgumentTypeException(String paramName, Type paramType) : base(paramName, $"Argument not of type {paramType}.") { }

		public ArgumentTypeException(String paramName, Type paramType, String message) : this(paramName, $"Argument not of type {paramType}. {message}") { }

#if !NETSTANDARD1_0
		private ArgumentTypeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
	}
}
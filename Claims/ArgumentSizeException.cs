using System;

namespace Defender {
	/// <summary>
	/// The exception that is thrown when a collection needs to be within a size, but is not.
	/// </summary>
	public class ArgumentSizeException : ArgumentException {
		public ArgumentSizeException() { }
		public ArgumentSizeException(String message) : base(message) { }
		public ArgumentSizeException(String message, Exception inner) : base(message, inner) { }
		public ArgumentSizeException(String paramName, String message) : base(message, paramName) { }
		public ArgumentSizeException(String paramName, String message, Exception inner) : base(message, paramName, inner) { }
	}
}

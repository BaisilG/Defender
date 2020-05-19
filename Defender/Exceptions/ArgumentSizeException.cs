using System;
#if !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Defender.Exceptions {
	/// <summary>
	/// The exception that is thrown when a collection needs to be within a size, but is not.
	/// </summary>
#if !NETSTANDARD1_0
	[Serializable]
#endif
	public sealed class ArgumentSizeException : ArgumentException {
		public ArgumentSizeException(String paramName, String message) : base(message, paramName) { }

#if !NETSTANDARD1_0
		private ArgumentSizeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
	}
}
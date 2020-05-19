using System;
#if !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Defender.Exceptions {
	/// <summary>
	/// Thrown when two objects are equal, but should not be.
	/// </summary>
#if !NETSTANDARD1_0
	[Serializable]
#endif
	public sealed class ArgumentEqualException : ArgumentException {
		public ArgumentEqualException(String paramName, String message) : base(paramName, message) { }

#if !NETSTANDARD1_0
		private ArgumentEqualException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
	}
}

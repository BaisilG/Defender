using System;
#if !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Defender.Exceptions {
	/// <summary>
	/// Thrown when two objects are unequal, but should be.
	/// </summary>
#if !NETSTANDARD1_0
	[Serializable]
#endif
	public sealed class ArgumentUnequalException : ArgumentException {
		public ArgumentUnequalException(String paramName, String message) : base(paramName, message) { }

#if !NETSTANDARD1_0
		private ArgumentUnequalException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
	}
}

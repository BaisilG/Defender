using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the stream being unreadable.
		/// </summary>
		/// <param name="stream">The <see cref="Stream"/> object.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CanRead(Stream stream, String name) {
			if (!stream.CanRead) {
				throw new ArgumentException("Stream is not readable", name);
			}
		}
	}
}
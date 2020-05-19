using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the stream being unwritable.
		/// </summary>
		/// <param name="stream">The <see cref="Stream"/> object.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CanWrite(Stream stream, String name) {
			if (!stream.CanWrite) {
				throw new ArgumentException("Stream is not writable", name);
			}
		}
	}
}
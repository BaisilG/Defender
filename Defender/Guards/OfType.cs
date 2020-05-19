using System;
using System.Runtime.CompilerServices;
using Defender.Exceptions;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument not being of the type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type the <paramref name="value"/> must be of.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OfType<T>(Object value, String name) {
			if (value is null || value.GetType() != typeof(T)) {
				throw new ArgumentTypeException(name, typeof(T));
			}
		}
	}
}
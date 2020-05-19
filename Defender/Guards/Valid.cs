using System;
using System.Runtime.CompilerServices;
#if !NETSTANDARD1_0
using FastEnumUtility;
#endif

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guards against the argument being an invalid (undeclared) enumeration value.
		/// </summary>
		/// <typeparam name="E">An <see cref="Enum"/> type.</typeparam>
		/// <param name="value">The <typeparamref name="E"/> value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <remarks>If <see cref="FlagsAttribute"/> is present, this guard is uneccessary and will even report false negatives.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Valid<E>(E value, String name) where E : struct, Enum {
#if NETSTANDARD1_0
			if (!Enum.IsDefined(typeof(E), value)) {
#else
			if (!FastEnum.IsDefined(value)) {
#endif
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be a valid '{typeof(E)}' value.");
			}
		}
	}
}
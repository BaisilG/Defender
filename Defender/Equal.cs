using System;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument being inequal to the specified value.
		/// </summary>
		/// <typeparam name="T">The type of the argument.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="other">The value <paramref name="value"/> must be equal to.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Equal<T>(T value, String name, T other) {
			if (!Equals(value, other)) {
				throw new ArgumentInequalException(name, $"Argument must equal {other}.");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="first"/> argument being inequal to the <paramref name="second"/> argument.
		/// </summary>
		/// <typeparam name="T">The type of the argument.</typeparam>
		/// <param name="first">The first value.</param>
		/// <param name="firstName">The name of the first argument.</param>
		/// <param name="second">The second value.</param>
		/// <param name="secondName">The name of the second argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Equal<T>(T first, String firstName, T second, String secondName) {
			if (!Equals(first, second)) {
				throw new ArgumentInequalException(firstName, $"Argument must equal {secondName}'s value of {second}.");
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Defender.Exceptions;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument being unequal to the specified value.
		/// </summary>
		/// <typeparam name="TValue">The type of the argument.</typeparam>
		/// <typeparam name="TOther">The type of the <paramref name="other"/> value.</typeparam>
		/// <param name="value">The value to guard.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="other">The value <paramref name="value"/> must be equal to.</param>
		/// <exception cref="ArgumentUnequalException">Thrown if the argument does not equal <paramref name="other"/>.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Equal<TValue, TOther>(TValue value, String name, TOther other) where TValue : IEquatable<TOther> {
			if (!value.Equals(other)) {
				throw new ArgumentUnequalException(name, $"Argument must equal {other}");
			}
		}

		/// <summary>
		/// Guard against the argument being unequal to the specified value.
		/// </summary>
		/// <param name="value">The value to guard.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="other">The value <paramref name="value"/> must be equal to.</param>
		/// <exception cref="ArgumentUnequalException">Thrown if the argument does not equal <paramref name="other"/>.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Equal(Object value, String name, Object other) {
			if (!Equals(value, other)) {
				throw new ArgumentUnequalException(name, $"Argument must equal {other}");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="first"/> argument being unequal to the <paramref name="second"/> argument.
		/// </summary>
		/// <typeparam name="TFirst">The type of the first argument.</typeparam>
		/// <typeparam name="TSecond">The type of the second argument.</typeparam>
		/// <param name="first">The first value.</param>
		/// <param name="firstName">The name of the first argument.</param>
		/// <param name="second">The second value.</param>
		/// <param name="secondName">The name of the second argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Equal<TFirst, TSecond>(TFirst first, String firstName, TSecond second, String secondName) where TFirst : IEquatable<TSecond> {
			if (!first.Equals(second)) {
				throw new ArgumentUnequalException(firstName, $"Argument must equal {secondName}'s value of {second}.");
			}
		}
	}
}
using System;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// 	Guard against the argument being lesser than <paramref name="lower"/> bound.
		/// 	</summary>
		/// 	<typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// 	<param name="value">The value.</param>
		/// 	<param name="name">The name of the argument.</param>
		/// 	<param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GreaterThanOrEqualTo<T>(T value, String name, T lower) where T : IComparable<T> {
			if (value.CompareTo(lower) < 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be greater than or equal to the lower bound '{lower}'.");
			}
		}
	}
}
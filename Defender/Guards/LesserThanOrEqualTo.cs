using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// 	Guard against the argument being greater than <paramref name="upper"/> bound.
		/// 	</summary>
		/// 	<typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// 	<param name="value">The value.</param>
		/// 	<param name="name">The name of the argument.</param>
		/// 	<param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LesserThanOrEqualTo<T>(T value, String name, T upper) where T : IComparable<T> {
			if (value.CompareTo(upper) > 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be lesser than or equal to the upper bound '{upper}'.");
			}
		}
	}
}
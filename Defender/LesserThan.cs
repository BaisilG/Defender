﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// 	Guard against the argument being greater than or equal to <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// 	<param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// 	<param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LesserThan<T>(T value, String name, T upper) where T : IComparable<T> {
			if (value.CompareTo(upper) >= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be lesser than the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than or equal to <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LesserThan<C>(C collection, String name, Int32 upper) where C : ICollection {
			if (collection.Count >= upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less elements than the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than or equal to <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection{T}"/> of <typeparamref name="T"/>.</typeparam>
		/// <typeparam name="T">The type of the elements of <typeparamref name="C"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LesserThan<C, T>(C collection, String name, Int32 upper) where C : ICollection<T> {
			if (collection.Count >= upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less elements than the upper bound '{upper}'.");
			}
		}
	}
}

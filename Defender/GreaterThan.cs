using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// 	Guard against the argument being lesser than or equal to <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// 	<param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// 	<param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GreaterThan<T>(T value, String name, T lower) where T : IComparable<T> {
			if (value.CompareTo(lower) <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be greater than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than or equal to <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GreaterThan<T>(T[] array, String name, Int32 lower)  {
			if (array.Length <= lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more elements than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than or equal to <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GreaterThan<C>(C collection, String name, Int32 lower) where C : ICollection {
			if (collection.Count <= lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more elements than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than or equal to <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection{T}"/> of <typeparamref name="T"/>.</typeparam>
		/// <typeparam name="T">The type of the elements of <typeparamref name="C"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GreaterThan<C, T>(C collection, String name, Int32 lower) where C : ICollection<T> {
			if (collection.Count <= lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more elements than the lower bound '{lower}'.");
			}
		}
	}
}

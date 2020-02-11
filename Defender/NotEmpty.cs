using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the string being empty.
		/// </summary>
		/// <param name="string">The string.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEmpty(String @string, String name) {
			if (@string.Length == 0) {
				throw new ArgumentException($"String must not be empty.", name);
			}
		}

		/// <summary>
		/// Guard against the array being empty.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEmpty<T>(T[] array, String name) {
			if (array.Length == 0) {
				throw new ArgumentException($"Array must not be empty.", name);
			}
		}

		/// <summary>
		/// Guard against the collection being empty.
		/// </summary>
		/// <typeparam name="C">The type of the collection; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEmpty<C>(C collection, String name) where C : ICollection {
			if (collection.Count == 0) {
				throw new ArgumentException($"Collection must not be empty.", name);
			}
		}

		/// <summary>
		/// Guard against the collection being empty.
		/// </summary>
		/// <typeparam name="C">The type of the collection; must be <see cref="ICollection{T}"/>.</typeparam>
		/// <typeparam name="T">The type of the elements in the collection.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEmpty<C, T>(C collection, String name) where C : ICollection<T> {
			if (collection.Count == 0) {
				throw new ArgumentException($"Collection must not be empty.", name);
			}
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the string having characters.
		/// </summary>
		/// <param name="string">The string.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty(String @string, String name) {
			if (@string.Length != 0) {
				throw new ArgumentSizeException(name, $"String must be empty.");
			}
		}

		/// <summary>
		/// Guard against the array having elements.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty<T>(T[] array, String name) {
			if (array.Length != 0) {
				throw new ArgumentSizeException(name, $"Array must be empty.");
			}
		}

#if !NETSTANDARD1_0
		/// <summary>
		/// Guard against the span having elements.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty<T>(ReadOnlySpan<T> span, String name) {
			if (span.Length != 0) {
				throw new ArgumentSizeException(name, $"Span must be empty.");
			}
		}

		/// <summary>
		/// Guard against the memory having elements.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty<T>(ReadOnlyMemory<T> memory, String name) {
			if (memory.Length != 0) {
				throw new ArgumentSizeException(name, $"Span must be empty.");
			}
		}
#endif

		/// <summary>
		/// Guard against the collection having elements.
		/// </summary>
		/// <typeparam name="C">The type of the collection; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty<C>(C collection, String name) where C : ICollection {
			if (collection.Count != 0) {
				throw new ArgumentSizeException(name, $"Collection must be empty.");
			}
		}

		/// <summary>
		/// Guard against the collection having elements.
		/// </summary>
		/// <typeparam name="C">The type of the collection; must be <see cref="ICollection{T}"/>.</typeparam>
		/// <typeparam name="T">The type of the elements in the collection.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Empty<C, T>(C collection, String name) where C : ICollection<T> {
			if (collection.Count != 0) {
				throw new ArgumentSizeException(name, $"Collection must be empty.");
			}
		}
	}
}

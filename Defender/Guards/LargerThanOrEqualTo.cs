using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Defender.Exceptions;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<T>(T[] array, String name, Int32 lower) {
			if (array.Length < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements than the lower bound '{lower}'.");
			}
		}

#if !NETSTANDARD1_0
		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<T>(Span<T> span, String name, Int32 lower) {
			if (span.Length < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<T>(ReadOnlySpan<T> span, String name, Int32 lower) {
			if (span.Length < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<T>(Memory<T> memory, String name, Int32 lower) {
			if (memory.Length < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<T>(ReadOnlyMemory<T> memory, String name, Int32 lower) {
			if (memory.Length < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements than the lower bound '{lower}'.");
			}
		}
#endif

		/// <summary>
		/// Guard against the argument being smaller than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LargerThanOrEqualTo<C>(C collection, String name, Int32 lower) where C : ICollection {
			if (collection.Count < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements to the lower bound '{lower}'.");
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
		public static void LargerThanOrEqualTo<C, T>(C collection, String name, Int32 lower) where C : ICollection<T> {
			if (collection.Count < lower) {
				throw new ArgumentSizeException(name, $"Argument must contain more or equal elements to the lower bound '{lower}'.");
			}
		}
	}
}

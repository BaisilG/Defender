using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Defender.Exceptions;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<T>(T[] array, String name, Int32 upper) {
			if (array.Length > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements than the upper bound '{upper}'.");
			}
		}

#if !NETSTANDARD1_0
		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<T>(Span<T> span, String name, Int32 upper) {
			if (span.Length > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements than the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<T>(ReadOnlySpan<T> span, String name, Int32 upper) {
			if (span.Length > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements than the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<T>(Memory<T> memory, String name, Int32 upper) {
			if (memory.Length > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements than the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<T>(ReadOnlyMemory<T> memory, String name, Int32 upper) {
			if (memory.Length > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements than the upper bound '{upper}'.");
			}
		}
#endif
		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<C>(C collection, String name, Int32 upper) where C : ICollection {
			if (collection.Count > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements to the upper bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being larger than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection{T}"/> of <typeparamref name="T"/>.</typeparam>
		/// <typeparam name="T">The type of the elements of <typeparamref name="C"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The upper bound.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SmallerThanOrEqualTo<C, T>(C collection, String name, Int32 upper) where C : ICollection<T> {
			if (collection.Count > upper) {
				throw new ArgumentSizeException(name, $"Argument must contain less or equal elements to the upper bound '{upper}'.");
			}
		}
	}
}

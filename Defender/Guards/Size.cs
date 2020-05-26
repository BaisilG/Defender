using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Defender.Exceptions;

namespace Defender {
	public static partial class Guard {
#if !NETSTANDARD1_0
		/// <summary>
		/// Guard against the span being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<T>(Span<T> span, String name, Int32 size) {
			if (span.Length != size) {
				throw new ArgumentSizeException(name, $"Span must contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the span being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<T>(ReadOnlySpan<T> span, String name, Int32 size) {
			if (span.Length != size) {
				throw new ArgumentSizeException(name, $"Span must contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the memory being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<T>(Memory<T> memory, String name, Int32 size) {
			if (memory.Length != size) {
				throw new ArgumentSizeException(name, $"Span must contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the memory being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<T>(ReadOnlyMemory<T> memory, String name, Int32 size) {
			if (memory.Length != size) {
				throw new ArgumentSizeException(name, $"Span must contain '{size}' elements.");
			}
		}
#endif

		/// <summary>
		/// Guard against the <paramref name="collection"/> being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<C>(C collection, String name, Int32 size) where C : ICollection {
			if (collection.Count != size) {
				throw new ArgumentSizeException(name, $"Argument must contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="collection"/> being of different size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection{T}"/> of <typeparamref name="T"/>.</typeparam>
		/// <typeparam name="T">The type of the elements of <typeparamref name="C"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Size<C, T>(C collection, String name, Int32 size) where C : ICollection<T> {
			if (collection.Count != size) {
				throw new ArgumentSizeException(name, $"Argument must contain '{size}' elements.");
			}
		}
	}
}

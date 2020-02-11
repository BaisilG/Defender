using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guard against the argument being equal to the specified value.
		/// </summary>
		/// <typeparam name="T">The type of the argument.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="other">The value <paramref name="value"/> must be equal to.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<T>(T value, String name, T other) {
			if (Equals(value, other)) {
				throw new ArgumentEqualException(name, $"Argument must not equal {other}.");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="first"/> argument being equal to the <paramref name="second"/> argument.
		/// </summary>
		/// <typeparam name="T">The type of the argument.</typeparam>
		/// <param name="first">The first value.</param>
		/// <param name="firstName">The name of the first argument.</param>
		/// <param name="second">The second value.</param>
		/// <param name="secondName">The name of the second argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<T>(T first, String firstName, T second, String secondName) {
			if (Equals(first, second)) {
				throw new ArgumentEqualException(firstName, $"Argument must not equal {secondName}'s value of {second}.");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="array"/> being of the same size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The unallowed size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<T>(T[] array, String name, Int32 size) {
			if (array.Length == size) {
				throw new ArgumentSizeException(name, $"Argument must not contain '{size}' elements.");
			}
		}

#if !NETSTANDARD1_0
		/// <summary>
		/// Guard against the span being of the same size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the span.</typeparam>
		/// <param name="span">The span.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<T>(ReadOnlySpan<T> span, String name, Int32 size) {
			if (span.Length == size) {
				throw new ArgumentSizeException(name, $"Span must not contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the memory being of the same size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements in the memory.</typeparam>
		/// <param name="memory">The memory.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The required size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<T>(ReadOnlyMemory<T> memory, String name, Int32 size) {
			if (memory.Length == size) {
				throw new ArgumentSizeException(name, $"Span must not contain '{size}' elements.");
			}
		}
#endif

		/// <summary>
		/// Guard against the <paramref name="collection"/> being of the same size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The unallowed size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<C>(C collection, String name, Int32 size) where C : ICollection {
			if (collection.Count == size) {
				throw new ArgumentSizeException(name, $"Argument must not contain '{size}' elements.");
			}
		}

		/// <summary>
		/// Guard against the <paramref name="collection"/> being of the same size from <paramref name="size"/>.
		/// </summary>
		/// <typeparam name="C">The type of the argument; must be <see cref="ICollection{T}"/> of <typeparamref name="T"/>.</typeparam>
		/// <typeparam name="T">The type of the elements of <typeparamref name="C"/>.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="size">The unallowed size.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotEqual<C, T>(C collection, String name, Int32 size) where C : ICollection<T> {
			if (collection.Count == size) {
				throw new ArgumentSizeException(name, $"Argument must not contain '{size}' elements.");
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Defender {
	public static class Arguments {
		/// <summary>
		/// Guard against the argument being lesser than or equal to <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		public static void GreaterThan<T>(T value, String name, T lower) where T : IComparable<T> {
			if (value.CompareTo(lower) <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be greater than the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being lesser than <paramref name="lower"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		public static void GreaterThanOrEqualTo<T>(T value, String name, T lower) where T : IComparable<T> {
			if (value.CompareTo(lower) < 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be greater than or equal to the lower bound '{lower}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being greater than or equal to <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The lower bound.</param>
		public static void LesserThan<T>(T value, String name, T upper) where T : IComparable<T> {
			if (value.CompareTo(upper) >= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be lesser than the lower bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being greater than <paramref name="upper"/> bound.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be <see cref="IComparable{T}"/>.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="upper">The lower bound.</param>
		public static void LesserThanOrEqualTo<T>(T value, String name, T upper) where T : IComparable<T> {
			if (value.CompareTo(upper) > 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument must be lesser than or equal to the lower bound '{upper}'.");
			}
		}

		/// <summary>
		/// Guard against the argument being <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be a struct.</typeparam>
		/// <param name="value">The <see cref="Nullable{T}"/> <typeparamref name="T"/> value.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotNull<T>(T? value, String name) where T : struct {
			if (value is null) {
				throw new ArgumentNullException(name);
			}
		}

		/// <summary>
		/// Guard against the argument being <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type of the argument; must be a class.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> value.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NotNull<T>(T value, String name) where T : class {
			if (value is null) {
				throw new ArgumentNullException(name);
			}
		}

		/// <summary>
		/// Guard against the argument not being of type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type the <paramref name="value"/> must be of.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Of<T>(Object? value, String name) {
			if (value is null || value.GetType() != typeof(T)) {
				throw new ArgumentTypeException(name, typeof(T));
			}
		}
	}
}

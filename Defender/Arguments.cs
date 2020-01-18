﻿using System;
using System.Runtime.CompilerServices;

namespace Defender {
	public static class Arguments {
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
		public static void Of<T>(Object value, String name) {
			if (value.GetType() != typeof(T)) {
				throw new ArgumentTypeException(name, typeof(T));
			}
		}
	}
}

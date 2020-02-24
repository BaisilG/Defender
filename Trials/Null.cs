﻿using System;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Is the <see langword="class"/> null?
		/// </summary>
		/// <typeparam name="T">The <see langword="class"/> type.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T?> Null<T>(this Claim<T?> claim) where T : class {
			if (claim.Value is object) {
				throw new NotNullException();
			}
			return claim;
		}

		/// <summary>
		/// Is the <see cref="Nullable{T}"/> <see langword="struct"/> null?
		/// </summary>
		/// <typeparam name="T">The <see cref="Nullable{T}"/> <see langword="struct"/> type.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T?> Null<T>(this Claim<T?> claim) where T : struct {
			if (claim.Value.HasValue) {
				throw new NotNullException();
			}
			return claim;
		}
	}
}

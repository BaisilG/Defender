using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Is the <see cref="String"/> empty?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<String> Empty(this Claim<String> claim) {
			if (claim.Value.Length != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}

		/// <summary>
		/// Is the <see cref="Array"/> empty?
		/// </summary>
		/// <typeparam name="T">The type of elements in the <see cref="Array"/>.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T[]> Empty<T>(this Claim<T[]> claim) {
			if (claim.Value.Length != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}

		/// <summary>
		/// Is the <see cref="IEnumerable"/> empty?
		/// </summary>
		/// <typeparam name="E">The sequence type.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<E> Empty<E>(this Claim<E> claim) where E : IEnumerable {
			IEnumerator enumerator = claim.Value.GetEnumerator();
			if (enumerator.MoveNext()) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}
	}
}

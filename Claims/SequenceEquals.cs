using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d array equal the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="T">The type of the elements in the array.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected array.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T[]> SequenceEquals<T>(this Claim<T[]> claim, T[] expected) {
			if (!expected.SequenceEqual(claim.Value)) {
				throw new EqualException(expected, claim.Value);
			}
			return claim;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d sequence equal the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="E">The sequence type.</typeparam>
		/// <typeparam name="T">The type of the elements in the sequence.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected sequence.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<E> SequenceEquals<E, T>(this Claim<E> claim, E expected) where E : IEnumerable<T> {
			if (!expected.SequenceEqual(claim.Value)) {
				throw new EqualException(expected, claim.Value);
			}
			return claim;
		}
	}
}

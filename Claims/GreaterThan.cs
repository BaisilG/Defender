using System;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Is the <see cref="Claim{T}"/>'d value greater than the <paramref name="lower"/>?
		/// </summary>
		/// <typeparam name="T">The type to compare.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="lower">The lower bound.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T> GreaterThan<T>(this Claim<T> claim, T lower) where T : IComparable<T> {
			if (claim.Value.CompareTo(lower) >= 0) {
				throw new GreaterThanException(claim.Value, lower);
			}
			return claim;
		}
	}
}

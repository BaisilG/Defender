using System;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Is the <see cref="Claim{T}"/>'d value lesser than the <paramref name="upper"/>?
		/// </summary>
		/// <typeparam name="T">The type to compare.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="upper">The upper bound.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T> LesserThan<T>(this Claim<T> claim, T upper) where T : IComparable<T> {
			if (claim.Value.CompareTo(upper) <= 0) {
				throw new LesserThanException(claim.Value, upper);
			}
			return claim;
		}
	}
}

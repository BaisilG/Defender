using System;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d value not equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected value.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public static Claim<Ta> NotEquals<Ta, Te>(this Claim<Ta> claim, Te expected) where Te : IEquatable<Ta> {
			if (expected.Equals(claim.Value)) {
				throw new NotEqualException(ArgumentFormatter.Format(expected), ArgumentFormatter.Format(claim.Value));
			}
			return claim;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d value not equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected value.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public static Claim<Object> NotEquals(this Claim<Object> claim, Object expected) {
			if (expected.Equals(claim.Value)) {
				throw new NotEqualException(ArgumentFormatter.Format(expected), ArgumentFormatter.Format(claim.Value));
			}
			return claim;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d <see cref="String"/> not equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public static Claim<String> NotEquals(this Claim<String> claim, String expected) {
			if (String.Equals(claim.Value, expected)) {
				throw new NotEqualException(expected, claim.Value);
			}
			return claim;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d <see cref="String"/> not equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <param name="comparisonType">The <see cref="StringComparison"/> to use for the comparison.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public static Claim<String> NotEquals(this Claim<String> claim, String expected, StringComparison comparisonType) {
			if (String.Equals(claim.Value, expected, comparisonType)) {
				throw new NotEqualException(expected, claim.Value);
			}
			return claim;
		}
	}
}

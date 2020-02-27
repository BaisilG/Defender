using System;
using Xunit.Sdk;

namespace Defender {
	public sealed class StringClaim : Claim<String> {
		internal StringClaim(String @string) : base(@string) { }

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d <see cref="String"/> equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public Claim<String> Equals(String expected) {
			if (!String.Equals(Value, expected)) {
				throw new NotEqualException(expected, Value);
			}
			return this;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d <see cref="String"/> equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <param name="comparisonType">The <see cref="StringComparison"/> to use for the comparison.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		public Claim<String> Equals(String expected, StringComparison comparisonType) {
			if (!String.Equals(Value, expected, comparisonType)) {
				throw new NotEqualException(expected, Value);
			}
			return this;
		}

	}
}

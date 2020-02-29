using System;
using Xunit.Sdk;

namespace Defender {
	public sealed class StringClaim : Claim<String> {
		internal StringClaim(String @string) : base(@string) { }

		/// <summary>
		/// Does the <see cref="StringClaim"/>'d <see cref="String"/> equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <returns>The calling <see cref="StringClaim"/>.</returns>
		public StringClaim Equals(String expected) {
			if (!String.Equals(Value, expected)) {
				throw new NotEqualException(expected, Value);
			}
			return this;
		}

		/// <summary>
		/// Does the <see cref="StringClaim"/>'d <see cref="String"/> equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="expected">The expected <see cref="String"/>.</param>
		/// <param name="comparisonType">The <see cref="StringComparison"/> to use for the comparison.</param>
		/// <returns>The calling <see cref="StringClaim"/>.</returns>
		public StringClaim Equals(String expected, StringComparison comparisonType) {
			if (!String.Equals(Value, expected, comparisonType)) {
				throw new NotEqualException(expected, Value);
			}
			return this;
		}

	}
}

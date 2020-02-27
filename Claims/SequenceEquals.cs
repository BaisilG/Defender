using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d sequence equal the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="Ea">The type of the actual sequence.</typeparam>
		/// <typeparam name="Te">The type of the expected sequence.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected sequence.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<Ta> SequenceEquals<Ta, Te>(this Claim<Ta> claim, Te expected) where Ta : IEnumerable where Te : IEnumerable {
			IEnumerator actEnum = claim.Value.GetEnumerator();
			IEnumerator expEnum = expected.GetEnumerator();
			while (actEnum.MoveNext() && expEnum.MoveNext()) {
				if (!expEnum.Current.Equals(actEnum.Current)) {
					throw new EqualException(expected, claim.Value);
				}
			}
			return claim;
		}
	}
}

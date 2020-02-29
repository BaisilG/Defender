using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d sequence equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected sequence.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<IEnumerable> SequenceEquals(this Claim<IEnumerable> claim, IEnumerable expected) {
			IEnumerator act = claim.Value.GetEnumerator();
			IEnumerator exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual;
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual;
			}
			return claim;
		NotEqual:
			throw new EqualException(expected, claim.Value);
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d sequence equal the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="Ta">The type of the actual sequence.</typeparam>
		/// <typeparam name="Te">The type of the expected sequence.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected sequence.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<IEnumerable<Ta>> SequenceEquals<Ta, Te>(this Claim<IEnumerable<Ta>> claim, IEnumerable<Te> expected) where Te : IEquatable<Ta> {
			IEnumerator<Ta> act = claim.Value.GetEnumerator();
			IEnumerator<Te> exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual;
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual;
			}
			return claim;
		NotEqual:
			throw new EqualException(expected, claim.Value);
		}
	}
}

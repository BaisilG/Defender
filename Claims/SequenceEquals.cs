using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		public static Claim<IEnumerable> SequenceEquals(this Claim<IEnumerable> claim, IEnumerable expected) {
			IEnumerator act = claim.Value.GetEnumerator();
			IEnumerator exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual; // Value wasn't equal
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual; // Not the same length
			}
			return claim;
		NotEqual:
			throw new EqualException(expected, claim.Value);
		}

		public static Claim<IEnumerable<Ta>> SequenceEquals<Ta, Te>(this Claim<IEnumerable<Ta>> claim, IEnumerable<Te> expected) where Te : IEquatable<Ta> {
			IEnumerator<Ta> act = claim.Value.GetEnumerator();
			IEnumerator<Te> exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual; // Value wasn't equal
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual; // Not the same length
			}
			return claim;
		NotEqual:
			throw new EqualException(expected, claim.Value);
		}
	}
}

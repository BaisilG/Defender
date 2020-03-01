using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public sealed class SequenceClaim : Claim<IEnumerable> {
		internal SequenceClaim(IEnumerable sequence) : base(sequence) { }

		public SequenceClaim SequenceEquals(IEnumerable expected) {
			IEnumerator act = Value.GetEnumerator();
			IEnumerator exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual; // Value wasn't equal
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual; // Not the same length
			}
			return this;
		NotEqual:
			throw new EqualException(expected, Value);
		}

	}

	public sealed class SequenceClaim<T> : Claim<IEnumerable<T>> {
		internal SequenceClaim(IEnumerable<T> sequence) : base(sequence) { }

		public SequenceClaim<T> SequenceEquals<Te>(IEnumerable<Te> expected) where Te : IEquatable<T> {
			IEnumerator<T> act = Value.GetEnumerator();
			IEnumerator<Te> exp = expected.GetEnumerator();
			while (act.MoveNext() && exp.MoveNext()) {
				if (!exp.Current.Equals(act.Current)) {
					goto NotEqual; // Value wasn't equal
				}
			}
			if (act.MoveNext() || exp.MoveNext()) {
				goto NotEqual; // Not the same length
			}
			return this;
		NotEqual:
			throw new EqualException(expected, Value);
		}

	}
}

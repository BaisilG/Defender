using System;
using System.Collections;
using System.Collections.Generic;

namespace Defender {
	public sealed class SequenceClaim : Claim<IEnumerable> {
		internal SequenceClaim(IEnumerable sequence) : base(sequence) { }
	}

	public sealed class SequenceClaim<T> : Claim<IEnumerable<T>> {
		internal SequenceClaim(IEnumerable<T> sequence) : base(sequence) { }
	}
}

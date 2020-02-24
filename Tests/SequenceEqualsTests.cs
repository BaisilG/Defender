using System;
using Defender;
using Xunit;

namespace Tests {
	public class SequenceEqualsTests : Trial {
		[Fact]
		public void SequenceEquals() => Claim(new[] { 1, 2, 3, 4}).SequenceEquals
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Defender;
using Xunit;

namespace Tests {
	[SuppressMessage("Performance", "HAA0603:Delegate allocation from a method group", Justification = "This is test code, stfu")]
	[SuppressMessage("Performance", "HAA0502:Explicit new reference type allocation", Justification = "This is test code, stfu")]
	[SuppressMessage("Blocker Code Smell", "S2699:Tests should include assertions", Justification = "Sonar doesn't understand something? Who ever would have guessed.")]
	public class ClaimTests : Trial {
		[Theory]
		[InlineData(0, 0)]
		[InlineData(5, 5)]
		[InlineData(-5, -5)]
		[InlineData(5.0, 5.0)]
		[InlineData(5.0, 5)]
		[InlineData(5, 5.0)]
		[InlineData('a', 'a')]
		[InlineData("", "")]
		[InlineData("hello", "hello")]
		public void Claim_Equals<T>(T actual, T expected) => Claim(actual).Equals(expected);

		[Fact]
		public void Claim_False() => Claim(false).False();

		[Theory]
		[InlineData("")]
		public void Claim_NotNull<T>(T actual) where T : class => Claim(actual).NotNull();

		[Theory]
		[InlineData(null)]
		public void Claim_Null(Object actual) => Claim(actual).Null();

		[Theory]
		[InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
		[InlineData(new[] { 'a', 'b', 'c' }, new[] { 'a', 'b', 'c' })]
		public void Claim_SequenceEquals_Array<T>(T actual, T expected) where T : IEnumerable => Claim(actual).SequenceEquals(expected);

		[Fact]
		public void Claim_SequenceEquals_List() {
			List<Int32> actual = new List<Int32>();
			List<Int32> expected = new List<Int32>();
			_ = Claim(actual).SequenceEquals(expected);
			actual.Add(1);
			expected.Add(1);
			_ = Claim(actual).SequenceEquals(expected);
			actual.Add(2);
			expected.Add(2);
			_ = Claim(actual).SequenceEquals(expected);
		}

		[Fact]
		public void Claim_SequenceEquals_Mixed() {
			List<Int32> actual = new List<Int32>();
			Int32[] expected = Array.Empty<Int32>();
			_ = Claim(actual).SequenceEquals(expected);
			actual.Add(1);
			expected = new[] { 1 };
			_ = Claim(actual).SequenceEquals(expected);
			actual.Add(2);
			expected = new[] { 1, 2 };
			_ = Claim(actual).SequenceEquals(expected);
		}

		[Fact]
		public void Claim_True() => Claim(true).True();
	}
}

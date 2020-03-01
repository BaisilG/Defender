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
		[InlineData(new Int32[] { })]
		public void Claim_Empty<T>(T actual) where T : IEnumerable => Claim.That(actual).Empty();

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
		public void Claim_Equals<T>(T actual, T expected) => Claim.That(actual).Equals(expected);

		[Theory]
		[InlineData("aa", "AA", StringComparison.OrdinalIgnoreCase)]
		[InlineData("encyclopedia", "encyclopedia", StringComparison.InvariantCulture)]
		[InlineData("encyclopædia", "encyclopaedia", StringComparison.InvariantCulture)]
		[InlineData("encyclopaedia", "encyclopædia", StringComparison.InvariantCulture)]
		public void Claim_Equals_String(String actual, String expected, StringComparison comparisonType) => Claim.That(actual).Equals(expected, comparisonType);

		[Theory]
		[InlineData(false)]
		public void Claim_False(Boolean actual) => Claim.That(actual).False();

		[Theory]
		[InlineData("", "a")]
		[InlineData("a", "")]
		public void Claim_NotEquals(String actual, String expected) => Claim.That(actual).NotEquals(expected);

		[Theory]
		[InlineData("")]
		public void Claim_NotNull<T>(T actual) where T : class => Claim.That(actual).NotNull();

		// This seemingly obtuse work around is required because Claim(null) resolves to Claim(Action action). In normal use, a null object will resolve to the expected type.
		[Theory]
		[InlineData(null)]
		public void Claim_Null(Object actual) => Claim.That(actual).Null();

		[Theory]
		[InlineData(new Int32[] { }, new Int32[] { })]
		[InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
		public void Claim_SequenceEquals_Array(Int32[] actual, Int32[] expected) => Claim.That(actual).SequenceEquals(expected);

		[Theory]
		[InlineData(new Int32[] { }, new Int32[] { })]
		[InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
		public void Claim_SequenceEquals_List(Int32[] actual, Int32[] expected) => Claim.That(new List<Int32>(actual)).SequenceEquals(new List<Int32>(expected));

		[Theory]
		[InlineData(true)]
		public void Claim_True(Boolean actual) => Claim.That(actual).True();
	}
}

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
		[InlineData("", "a")]
		[InlineData("a", "")]
		public void Claim_NotEquals(String actual, String expected) => Claim(actual).NotEquals(expected);

		[Theory]
		[InlineData("")]
		public void Claim_NotNull<T>(T actual) where T : class => Claim(actual).NotNull();

		// This seemingly obtuse work around is required because Claim(null) resolves to Claim(Action action). In normal use, a null object will resolve to the expected type.
		[Theory]
		[InlineData(null)]
		public void Claim_Null(Object actual) => Claim(actual).Null();

		[Fact]
		public void Claim_True() => Claim(true).True();
	}
}

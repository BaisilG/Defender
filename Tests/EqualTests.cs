using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Defender;
using Defender.Exceptions;
using static Defender.Guard;

namespace Tests {
	public class EqualTests {
		[Theory]
		[InlineData(1, 1, false)]
		[InlineData(1, 2, true)]
		[InlineData(2, 1, true)]
		[InlineData('a', 'a', false)]
		[InlineData('a', 'b', true)]
		[InlineData('b', 'a', true)]
		[InlineData("hi", "hi", false)]
		[InlineData("hi", "no", true)]
		[InlineData("no", "hi", true)]
		public void Method<T>(T value, T other, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentUnequalException>(() => Equal(value, "value", other));
			} else {
				Equal(value, "value", other);
			}
		}
	}
}

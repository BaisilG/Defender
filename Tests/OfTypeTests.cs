using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Defender;
using Defender.Exceptions;
using static Defender.Guard;

namespace Tests {
	public class OfTypeTests {
		[Theory]
		[InlineData(null, true)]
		[InlineData(1, false)]
		[InlineData(1.5, true)]
		[InlineData('a', true)]
		[InlineData("hi", true)]
		public static void Int32(Object value, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentTypeException>(() => OfType<Int32>(value, "value"));
			} else {
				OfType<Int32>(value, "value");
			}
		}

		[Theory]
		[InlineData(null, true)]
		[InlineData(1, true)]
		[InlineData(1.5, true)]
		[InlineData('a', true)]
		[InlineData("hi", false)]
		public static void String(Object value, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentTypeException>(() => OfType<String>(value, "value"));
			} else {
				OfType<String>(value, "value");
			}
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Defender;
using Defender.Exceptions;
using static Defender.Guard;

namespace Tests {
	public class EmptyTests {
		[Theory]
		[InlineData(new Object[] { }, false)]
		[InlineData(new Object[] { 1, 2, 3 }, true)]
		public void Collection(Object[] list, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentSizeException>(() => Empty(new ArrayList(list), "list"));
			} else {
				Empty(new ArrayList(list), "list");
			}
		}

		[Theory]
		[InlineData(null, false)]
		[InlineData(new Int32[] { }, false)]
		[InlineData(new Int32[] { 1, 2, 3 }, true)]
		public void Generic_Collection(Int32[] list, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentSizeException>(() => Empty(new List<Int32>(list), "list"));
			} else {
				Empty(new List<Int32>(), "list");
			}
		}

		[Theory]
		[InlineData(null, true)]
		[InlineData("", false)]
		[InlineData("hello", true)]
		public void String(String @string, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentSizeException>(() => Empty("hello", "list"));
			} else {
				Empty(@string, "string");
			}
		}
	}
}

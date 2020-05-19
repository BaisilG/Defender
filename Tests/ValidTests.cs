using System;
using Xunit;
using Defender;
using static Defender.Guard;

namespace Tests {
	public class ValidTests {
		[Theory]
		[InlineData(-1, true)]
		[InlineData(0, false)]
		[InlineData(1, false)]
		[InlineData(16, true)]
		public void ConsoleColor(Int32 value, Boolean throws) {
			if (throws) {
				_ = Assert.Throws<ArgumentOutOfRangeException>(() => Valid((ConsoleColor)value, "value"));
			} else {
				Valid((ConsoleColor)value, "value");
			}
		}
	}
}

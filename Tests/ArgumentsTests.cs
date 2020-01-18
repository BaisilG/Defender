using System;
using Defender;
using static Defender.Arguments;
using Xunit;

namespace Tests {
	public class ArgumentsTests {
		[Theory]
		[InlineData(10, 1)]
		[InlineData(1, 0)]
		public void GreaterThan_Succeeding(Int32 param, Int32 lower) => GreaterThan(param, nameof(param), lower);

		[Theory]
		[InlineData(10, 10)]
		[InlineData(1, 10)]
		public void GreaterThan_Failing(Int32 param, Int32 lower) => Assert.Throws<ArgumentOutOfRangeException>(() => GreaterThan(param, nameof(param), lower));

		[Theory]
		[InlineData(5)]
		public void NotNull_Struct_Succeeding(Int32? param) => NotNull(param, nameof(param));

		[Theory]
		[InlineData(null)]
		public void NotNull_Struct_Failing(Int32? param) => Assert.Throws<ArgumentNullException>(() => NotNull(param, nameof(param)));

		[Theory]
		[InlineData("Hello")]
		public void NotNull_Class_Succeeding(String param) => NotNull(param, nameof(param));

		[Theory]
		[InlineData(null)]
		public void NotNull_Class_Failing(String param) => Assert.Throws<ArgumentNullException>(() => NotNull(param, nameof(param)));

		[Theory]
		[InlineData(42)]
		public void Of_Int32_Succeeding(Object param) => Of<Int32>(param, nameof(param));

		[Theory]
		[InlineData("Hello")]
		public void Of_Int32_Failing(Object param) => Assert.Throws<ArgumentTypeException>(() => Of<Int32>(param, nameof(param)));

		[Theory]
		[InlineData("Hello")]
		public void Of_String_Succeeding(Object param) => Of<String>(param, nameof(param));

		[Theory]
		[InlineData(42)]
		public void Of_String_Failing(Object param) => Assert.Throws<ArgumentTypeException>(() => Of<String>(param, nameof(param)));
	}
}

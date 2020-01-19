using System;
using System.Collections;
using System.Collections.Generic;
using Defender;
using static Defender.Guard;
using Xunit;

namespace Tests {
	public class ArgumentsTests {
		[Fact]
		public void Empty_Succeeding() => Empty(new ArrayList(), "list");

		[Fact]
		public void Empty_Failing() => Assert.Throws<ArgumentException>(() => Empty(new ArrayList() { 1, 2 }, "list"));

		[Fact]
		public void Empty_Generic_Succeeding() => Empty(new List<Int32>(), "list");

		[Fact]
		public void Empty_Generic_Failing() => Assert.Throws<ArgumentException>(() => Empty(new List<Int32>() { 1, 2 }, "list"));

		[Fact]
		public void Empty_String_Succeeding() => Empty("", "list");

		[Fact]
		public void Empty_String_Failing() => Assert.Throws<ArgumentException>(() => Empty("hello", "list"));


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
		public void Of_Int32_Succeeding(Object param) => OfType<Int32>(param, nameof(param));

		[Theory]
		[InlineData("Hello")]
		[InlineData(null)]
		public void Of_Int32_Failing(Object param) => Assert.Throws<ArgumentTypeException>(() => OfType<Int32>(param, nameof(param)));

		[Theory]
		[InlineData("Hello")]
		public void Of_String_Succeeding(Object param) => OfType<String>(param, nameof(param));

		[Theory]
		[InlineData(42)]
		[InlineData(null)]
		public void Of_String_Failing(Object param) => Assert.Throws<ArgumentTypeException>(() => OfType<String>(param, nameof(param)));
	}
}

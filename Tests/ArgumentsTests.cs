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
		[InlineData(5, 5)]
		public void Equal_Struct_Succeeding(Int32 param, Int32 other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData(5, 6)]
		public void Equal_Struct_Failing(Int32 param, Int32 other) => Assert.Throws<ArgumentInequalException>(() => Equal(param, nameof(param), other));

		[Theory]
		[InlineData(5, 5)]
		[InlineData(null, null)]
		public void Equal_NullableStruct_Succeeding(Int32? param, Int32? other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData(5, 6)]
		[InlineData(5, null)]
		public void Equal_NullableStruct_Failing(Int32? param, Int32? other) => Assert.Throws<ArgumentInequalException>(() => Equal(param, nameof(param), other));

		[Theory]
		[InlineData("", "")]
		[InlineData(null, null)]
		public void Equal_Class_Succeeding(String param, String other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData("", "oh no")]
		[InlineData("", null)]
		public void Equal_Class_Failing(String param, String other) => Assert.Throws<ArgumentInequalException>(() => Equal(param, nameof(param), other));

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

		[Theory]
		[InlineData(ConsoleColor.Red)]
		[InlineData(ConsoleColor.White)]
		public void Valid_Enum_Succeeding(ConsoleColor param) => Valid(param, nameof(param));

		[Theory]
		[InlineData((ConsoleColor)20)]
		public void Valid_Enum_Failing(ConsoleColor param) => Assert.Throws<ArgumentOutOfRangeException>(() => Valid(param, nameof(param)));

		[Theory]
		[InlineData(5, 1, 10, true)]
		[InlineData(10, 1, 10, true)]
		public void Within_Int32_Succeeding(Int32 param, Int32 lower, Int32 upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData(15, 1, 10, true)]
		[InlineData(10, 1, 10, false)]
		public void Within_Int32_Failing(Int32 param, Int32 lower, Int32 upper, Boolean inclusive) => Assert.Throws<ArgumentOutOfRangeException>(() => Within(param, nameof(param), lower, upper, inclusive));

		[Theory]
		[InlineData(5, 1, 10, true)]
		[InlineData(10, 1, 10, true)]
		public void Within_UInt32_Succeeding(UInt32 param, UInt32 lower, UInt32 upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData(15, 1, 10, true)]
		[InlineData(10, 1, 10, false)]
		public void Within_UInt32_Failing(UInt32 param, UInt32 lower, UInt32 upper, Boolean inclusive) => Assert.Throws<ArgumentOutOfRangeException>(() => Within(param, nameof(param), lower, upper, inclusive));

		[Theory]
		[InlineData("cake", "alpha", "omega", true)]
		[InlineData("omega", "alpha", "omega", true)]
		public void Within_IComparable_Succeeding(String param, String lower, String upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData("zeta", "alpha", "omega", true)]
		[InlineData("omega", "alpha", "omega", false)]
		public void Within_IComparable_Failing(String param, String lower, String upper, Boolean inclusive) => Assert.Throws<ArgumentOutOfRangeException>(() => Within(param, nameof(param), lower, upper, inclusive));
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Defender;
using static Defender.Guard;
using Xunit;

namespace Tests {
	[SuppressMessage("Performance", "HAA0603:Delegate allocation from a method group", Justification = "This is test code, stfu")]
	[SuppressMessage("Performance", "HAA0502:Explicit new reference type allocation", Justification = "This is test code, stfu")]
	public class GuardTests : Trial {
		[Fact]
		public void Empty_Succeeding() => Empty(new ArrayList(), "list");

		[Fact]
		public void Empty_Failing() => Claim.That(() => Empty(new ArrayList() { 1, 2 }, "list")).Throws<ArgumentException>();

		[Fact]
		public void Empty_Generic_Succeeding() => Empty(new List<Int32>(), "list");

		[Fact]
		public void Empty_Generic_Failing() => Claim.That(() => Empty(new List<Int32>() { 1, 2 }, "list")).Throws<ArgumentException>();

		[Fact]
		public void Empty_String_Succeeding() => Empty("", "list");

		[Fact]
		public void Empty_String_Failing() => Claim.That(() => Empty("hello", "list")).Throws<ArgumentException>();

		[Theory]
		[InlineData(5, 5)]
		public void Equal_Struct_Succeeding(Int32 param, Int32 other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData(5, 6)]
		public void Equal_Struct_Failing(Int32 param, Int32 other) => Claim.That(() => Equal(param, nameof(param), other)).Throws<ArgumentInequalException>();

		[Theory]
		[InlineData(5, 5)]
		[InlineData(null, null)]
		public void Equal_NullableStruct_Succeeding(Int32? param, Int32? other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData(5, 6)]
		[InlineData(5, null)]
		public void Equal_NullableStruct_Failing(Int32? param, Int32? other) => Claim.That(() => Equal(param, nameof(param), other)).Throws<ArgumentInequalException>();

		[Theory]
		[InlineData("", "")]
		[InlineData(null, null)]
		public void Equal_Class_Succeeding(String param, String other) => Equal(param, nameof(param), other);

		[Theory]
		[InlineData("", "oh no")]
		[InlineData("", null)]
		public void Equal_Class_Failing(String param, String other) => Claim.That(() => Equal(param, nameof(param), other)).Throws<ArgumentInequalException>();

		[Theory]
		[InlineData(10, 1)]
		[InlineData(1, 0)]
		public void GreaterThan_Succeeding(Int32 param, Int32 lower) => GreaterThan(param, nameof(param), lower);

		[Theory]
		[InlineData(10, 10)]
		[InlineData(1, 10)]
		public void GreaterThan_Failing(Int32 param, Int32 lower) => Claim.That(() => GreaterThan(param, nameof(param), lower)).Throws<ArgumentOutOfRangeException>();

		[Fact]
		public void GreaterThan_Collection_Succeeding() {
			ICollection collection = new ArrayList(new[] { 1, 2, 3, 4, 5 });
			GreaterThan(collection, nameof(collection), 3);
		}

		[Fact]
		public void GreaterThan_GenericCollection_Failing() {
			ICollection<Int32> collection = new List<Int32>(new[] { 1, 2, 3, 4, 5 });
			_ = Claim.That(() => GreaterThan<ICollection<Int32>, Int32>(collection, nameof(collection), 8)).Throws<ArgumentSizeException>();
		}

		[Fact]
		public void GreaterThan_GenericCollection_Succeeding() {
			ICollection<Int32> collection = new List<Int32>(new[] { 1, 2, 3, 4, 5 });
			GreaterThan<ICollection<Int32>, Int32>(collection, nameof(collection), 3);
		}

		[Fact]
		public void GreaterThan_Collection_Failing() {
			ICollection collection = new ArrayList(new[] { 1, 2, 3, 4, 5 });
			_ = Claim.That(() => GreaterThan(collection, nameof(collection), 8)).Throws<ArgumentSizeException>();
		}

		[Theory]
		[InlineData(5)]
		public void NotNull_Struct_Succeeding(Int32? param) => NotNull(param, nameof(param));

		[Theory]
		[InlineData(null)]
		public void NotNull_Struct_Failing(Int32? param) => Claim.That(() => NotNull(param, nameof(param))).Throws<ArgumentNullException>();

		[Theory]
		[InlineData("Hello")]
		public void NotNull_Class_Succeeding(String param) => NotNull(param, nameof(param));

		[Theory]
		[InlineData(null)]
		public void NotNull_Class_Failing(String param) => Claim.That(() => NotNull(param, nameof(param))).Throws<ArgumentNullException>();

		[Theory]
		[InlineData(42)]
		public void Of_Int32_Succeeding(Object param) => OfType<Int32>(param, nameof(param));

		[Theory]
		[InlineData("Hello")]
		[InlineData(null)]
		public void Of_Int32_Failing(Object param) => Claim.That(() => OfType<Int32>(param, nameof(param))).Throws<ArgumentTypeException>();

		[Theory]
		[InlineData("Hello")]
		public void Of_String_Succeeding(Object param) => OfType<String>(param, nameof(param));

		[Theory]
		[InlineData(42)]
		[InlineData(null)]
		public void Of_String_Failing(Object param) => Claim.That(() => OfType<String>(param, nameof(param))).Throws<ArgumentTypeException>();

		[Theory]
		[InlineData(ConsoleColor.Red)]
		[InlineData(ConsoleColor.White)]
		public void Valid_Enum_Succeeding(ConsoleColor param) => Valid(param, nameof(param));

		[Theory]
		[InlineData((ConsoleColor)20)]
		public void Valid_Enum_Failing(ConsoleColor param) => Claim.That(() => Valid(param, nameof(param))).Throws<ArgumentOutOfRangeException>();

		[Theory]
		[InlineData(5, 1, 10, true)]
		[InlineData(10, 1, 10, true)]
		public void Within_Int32_Succeeding(Int32 param, Int32 lower, Int32 upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData(15, 1, 10, true)]
		[InlineData(10, 1, 10, false)]
		public void Within_Int32_Failing(Int32 param, Int32 lower, Int32 upper, Boolean inclusive) => Claim.That(() => Within(param, nameof(param), lower, upper, inclusive)).Throws<ArgumentOutOfRangeException>();

		[Theory]
		[InlineData(5, 1, 10, true)]
		[InlineData(10, 1, 10, true)]
		public void Within_UInt32_Succeeding(UInt32 param, UInt32 lower, UInt32 upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData(15, 1, 10, true)]
		[InlineData(10, 1, 10, false)]
		public void Within_UInt32_Failing(UInt32 param, UInt32 lower, UInt32 upper, Boolean inclusive) => Claim.That(() => Within(param, nameof(param), lower, upper, inclusive)).Throws<ArgumentOutOfRangeException>();

		[Theory]
		[InlineData("cake", "alpha", "omega", true)]
		[InlineData("omega", "alpha", "omega", true)]
		public void Within_IComparable_Succeeding(String param, String lower, String upper, Boolean inclusive) => Within(param, nameof(param), lower, upper, inclusive);

		[Theory]
		[InlineData("zeta", "alpha", "omega", true)]
		[InlineData("omega", "alpha", "omega", false)]
		public void Within_IComparable_Failing(String param, String lower, String upper, Boolean inclusive) => Claim.That(() => Within(param, nameof(param), lower, upper, inclusive)).Throws<ArgumentOutOfRangeException>();
	}
}
